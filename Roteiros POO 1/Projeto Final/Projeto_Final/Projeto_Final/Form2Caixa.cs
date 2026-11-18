using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Form2Caixa : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form2Caixa()
        {
            InitializeComponent();
            this.btnBuscarProduto.Click += new System.EventHandler(this.btnBuscarProduto_Click);
        }

        private void panel1Cabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnBuscarProduto_Click(object? sender, EventArgs e)
        {
            string pesquisa = textBuscarProduto.Text.Trim();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                MessageBox.Show("Digite o nome ou código de barras do produto.");
                textBuscarProduto.Focus();
                return;
            }

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                string sql = @"
                   SELECT
                    id_produto,
                    codigo_barras,
                    nome,
                    preco,
                    estoque
                  FROM produto
                  WHERE ativo = TRUE
                  AND (
                      nome ILIKE '%' || @pesquisa || '%'
                      OR codigo_barras = @pesquisa
                  );";

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@pesquisa", pesquisa);

                    dgvProdutos.Rows.Clear();

                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        bool encontrouProduto = false;

                        while (leitor.Read())
                        {
                            encontrouProduto = true;

                            int indiceLinha = dgvProdutos.Rows.Add(
                                leitor["codigo_barras"].ToString() ?? "",
                                leitor["nome"].ToString() ?? "",
                                leitor["preco"],
                                leitor["estoque"]
                            );

                            dgvProdutos.Rows[indiceLinha].Tag = leitor["id_produto"];
                        }

                        if (!encontrouProduto)
                        {
                            MessageBox.Show("Nenhum produto encontrado.");
                        }
                    }
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para adicionar à venda.");
                return;
            }

            DataGridViewRow linhaSelecionada = dgvProdutos.SelectedRows[0];

            string codigo = linhaSelecionada.Cells[0].Value?.ToString() ?? "";
            string nome = linhaSelecionada.Cells[1].Value?.ToString() ?? "";
            decimal preco = Convert.ToDecimal(linhaSelecionada.Cells[2].Value);

            string entrada = Microsoft.VisualBasic.Interaction.InputBox(
                "Informe a quantidade desejada:",
                "Quantidade do produto",
                "1"
            );

            if (!int.TryParse(entrada, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            int estoque = Convert.ToInt32(linhaSelecionada.Cells[3].Value);

            int idProduto = Convert.ToInt32(linhaSelecionada.Tag);

            int quantidadeNoCarrinho = 0;

            foreach (DataGridViewRow linha in dgvItensVenda.Rows)
            {
                if (linha.Tag != null &&
                    Convert.ToInt32(linha.Tag) == idProduto)
                {
                    quantidadeNoCarrinho += Convert.ToInt32(linha.Cells[2].Value);
                }
            }

            if (quantidade + quantidadeNoCarrinho > estoque)
            {
                int disponivel = estoque - quantidadeNoCarrinho;

                MessageBox.Show(
                    "Quantidade solicitada maior que o estoque disponível.\n" +
                    "Quantidade disponível para adicionar: " + disponivel
                );

                return;
            }

            decimal subtotal = preco * quantidade;

            int indiceLinha = dgvItensVenda.Rows.Add(
                codigo,
                nome,
                quantidade,
                preco,
                subtotal
            );

            dgvItensVenda.Rows[indiceLinha].Tag = linhaSelecionada.Tag;

            CalcularTotal();

        }
        private void CalcularTotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow linha in dgvItensVenda.Rows)
            {
                if (linha.Cells[4].Value != null)
                {
                    subtotal += Convert.ToDecimal(linha.Cells[4].Value);
                }
            }

            decimal valorDesconto = Math.Round(
                subtotal * percentualDesconto / 100m,
                2,
                MidpointRounding.AwayFromZero
            );

            decimal total = subtotal - valorDesconto;

            lblSubtotal.Text = subtotal.ToString("C2");
            lblDesconto.Text = valorDesconto.ToString("C2");
            lblTotal.Text = total.ToString("C2");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItensVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto para remover da venda.");
                return;
            }

            dgvItensVenda.Rows.RemoveAt(
                dgvItensVenda.SelectedRows[0].Index
            );

            CalcularTotal();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (dgvItensVenda.Rows.Count == 0)
            {
                MessageBox.Show("Não há produtos na venda para limpar.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente remover todos os produtos da venda?",
                "Confirmar limpeza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
            {
                return;
            }

            dgvItensVenda.Rows.Clear();

            CalcularTotal();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (dgvItensVenda.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto antes de finalizar a venda.");
                return;
            }

            if (cmbFormaPagamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma forma de pagamento.");
                cmbFormaPagamento.Focus();
                return;
            }

            if (!decimal.TryParse(txtDescontoPercentual.Text, out decimal percentual) ||
            percentual < 0 || percentual > 100)
            {
                MessageBox.Show(
                    "Informe uma porcentagem de desconto válida entre 0 e 100."
                );

                txtDescontoPercentual.Focus();
                return;
            }

            percentualDesconto = percentual;

            foreach (DataGridViewRow linha in dgvItensVenda.Rows)
            {
                if (linha.Tag == null)
                {
                    MessageBox.Show("Erro ao identificar um dos produtos da venda.");
                    return;
                }
            }

            string formaPagamento = cmbFormaPagamento.SelectedItem!.ToString()!;

            switch (formaPagamento)
            {
                case "Dinheiro":
                    formaPagamento = "Dinheiro";
                    break;

                case "Pix":
                    formaPagamento = "Pix";
                    break;

                case "Cartão de crédito":
                    formaPagamento = "Credito";
                    break;

                case "Cartão de débito":
                    formaPagamento = "Debito";
                    break;

                default:
                    MessageBox.Show("Forma de pagamento inválida.");
                    return;
            }

            decimal subtotal = 0;

            foreach (DataGridViewRow linha in dgvItensVenda.Rows)
            {
                subtotal += Convert.ToDecimal(linha.Cells[4].Value);
            }

            decimal valorDesconto = Math.Round(
                subtotal * percentualDesconto / 100m,
                2,
                MidpointRounding.AwayFromZero
            );

            decimal valorTotal = subtotal - valorDesconto;

            try
            {
                using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
                {
                    using (NpgsqlTransaction transacao = conexao.BeginTransaction())
                    {
                        string sqlVenda = @"
                        INSERT INTO venda
                        (data_hora, subtotal, percentual_desconto, valor_desconto,
                        valor_total, forma_pagamento, status)
                        VALUES
                        (CURRENT_TIMESTAMP, @subtotal, @percentualDesconto, @valorDesconto,
                        @valorTotal, @formaPagamento, 'Concluida')
                        RETURNING id_venda;
                    ";

                        int idVenda;

                        using (NpgsqlCommand comando = new NpgsqlCommand(sqlVenda, conexao, transacao))
                        {
                            comando.Parameters.AddWithValue("@subtotal", subtotal);
                            comando.Parameters.AddWithValue("@percentualDesconto", percentualDesconto);
                            comando.Parameters.AddWithValue("@valorDesconto", valorDesconto);
                            comando.Parameters.AddWithValue("@valorTotal", valorTotal);
                            comando.Parameters.AddWithValue("@formaPagamento", formaPagamento);

                            idVenda = Convert.ToInt32(comando.ExecuteScalar());

                        }

                        foreach (DataGridViewRow linha in dgvItensVenda.Rows)
                        {
                            int idProduto = Convert.ToInt32(linha.Tag);
                            int quantidade = Convert.ToInt32(linha.Cells[2].Value);
                            decimal precoUnitario = Convert.ToDecimal(linha.Cells[3].Value);
                            decimal subtotalItem = Convert.ToDecimal(linha.Cells[4].Value);

                            string sqlItem = @"
                                INSERT INTO item_venda
                                (id_venda, id_produto, quantidade, preco_unitario, subtotal)
                                VALUES
                                (@idVenda, @idProduto, @quantidade, @precoUnitario, @subtotal);
                            ";

                            using (NpgsqlCommand comandoItem = new NpgsqlCommand(sqlItem, conexao, transacao))
                            {
                                comandoItem.Parameters.AddWithValue("@idVenda", idVenda);
                                comandoItem.Parameters.AddWithValue("@idProduto", idProduto);
                                comandoItem.Parameters.AddWithValue("@quantidade", quantidade);
                                comandoItem.Parameters.AddWithValue("@precoUnitario", precoUnitario);
                                comandoItem.Parameters.AddWithValue("@subtotal", subtotalItem);

                                comandoItem.ExecuteNonQuery();
                            }

                            string sqlEstoque = @"
                                UPDATE produto
                                SET estoque = estoque - @quantidade
                                WHERE id_produto = @idProduto
                                AND estoque >= @quantidade;
                            ";

                            using (NpgsqlCommand comandoEstoque = new NpgsqlCommand(sqlEstoque, conexao, transacao))
                            {
                                comandoEstoque.Parameters.AddWithValue("@quantidade", quantidade);
                                comandoEstoque.Parameters.AddWithValue("@idProduto", idProduto);

                                int linhasAfetadas = comandoEstoque.ExecuteNonQuery();

                                if (linhasAfetadas == 0)
                                {
                                    throw new InvalidOperationException(
                                            "Estoque insuficiente para o produto: " + linha.Cells[1].Value
                                        );
                                }
                            }
                        }
                        transacao.Commit();
                    }

                }

                MessageBox.Show(
                    "Venda finalizada com sucesso!",
                    "Venda concluída",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                dgvItensVenda.Rows.Clear();

                percentualDesconto = 0m;
                txtDescontoPercentual.Text = "0";

                CalcularTotal();

                cmbFormaPagamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao finalizar a venda: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            if (dgvItensVenda.Rows.Count == 0)
            {
                MessageBox.Show("Não existe uma venda em andamento para cancelar.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente cancelar esta venda?",
                "Cancelar venda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
            {
                return;
            }

            dgvItensVenda.Rows.Clear();

            percentualDesconto = 0m;
            txtDescontoPercentual.Text = "0";

            CalcularTotal();

            cmbFormaPagamento.SelectedIndex = -1;

            MessageBox.Show(
                "Venda cancelada com sucesso!",
                "Venda cancelada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private decimal percentualDesconto = 0m;
        private void txtDescontoPercentual_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescontoPercentual.Text))
            {
                percentualDesconto = 0m;
                CalcularTotal();
                return;
            }

            if (decimal.TryParse(txtDescontoPercentual.Text, out decimal percentual))
            {
                if (percentual >= 0 && percentual <= 100)
                {
                    percentualDesconto = percentual;
                    CalcularTotal();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
