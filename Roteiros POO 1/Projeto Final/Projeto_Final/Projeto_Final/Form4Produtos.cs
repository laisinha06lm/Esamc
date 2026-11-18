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
    public partial class Form4Produtos : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        private int? idProdutoSelecionado = null;

        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form4Produtos()
        {
            InitializeComponent();

            btnCadastrar.Click += btnCadastrar_Click;

            CarregarCategorias();

            CarregarProdutos();

            btnPesquisarProduto.Click += btnPesquisarProduto_Click;

            dgvProdutosCadastrados.CellClick += dgvProdutosCadastrados_CellClick;

            btnAtualizar.Click += btnAtualizar_Click;

            btnExcluir.Click += btnExcluir_Click;

            btnLimpar.Click += btnLimpar_Click;

        }
        private void panel1Cabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CarregarCategorias()
        {
            string sql = @"
                SELECT id_categoria, nome
                FROM categoria
                WHERE ativa = TRUE
                ORDER BY nome;
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        DataTable tabela = new DataTable();

                        tabela.Load(leitor);

                        cmbCategoria.DataSource = tabela;
                        cmbCategoria.DisplayMember = "nome";
                        cmbCategoria.ValueMember = "id_categoria";
                        cmbCategoria.SelectedIndex = -1;
                    }
                }
            }
        }

        private void CarregarProdutos(string pesquisa = "")
        {
            string sql = @"
                SELECT
                p.id_produto,
                p.codigo_barras,
                p.nome,
                c.nome AS categoria,
                p.preco,
                p.estoque,
                p.ativo
                FROM produto p
                INNER JOIN categoria c
                ON p.id_categoria = c.id_categoria
                    WHERE
                    (@pesquisa = ''
                    OR p.nome ILIKE @filtro
                    OR p.codigo_barras ILIKE @filtro)
                ORDER BY p.nome;
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@pesquisa", pesquisa);
                    comando.Parameters.AddWithValue("@filtro", "%" + pesquisa + "%");

                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        dgvProdutosCadastrados.Rows.Clear();

                        while (leitor.Read())
                        {
                            int idProduto = Convert.ToInt32(leitor["id_produto"]);

                            string codigo = leitor["codigo_barras"].ToString() ?? "";
                            string nome = leitor["nome"].ToString() ?? "";
                            string categoria = leitor["categoria"].ToString() ?? "";

                            string preco = Convert.ToDecimal(leitor["preco"]).ToString("C2");

                            int estoque = Convert.ToInt32(leitor["estoque"]);

                            string status = Convert.ToBoolean(leitor["ativo"])
                                ? "Ativo"
                                : "Inativo";

                            dgvProdutosCadastrados.Rows.Add(
                                idProduto,
                                codigo,
                                nome,
                                categoria,
                                preco,
                                estoque,
                                status
                            );
                        }
                    }
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("Informe o nome do produto.");
                txtNomeProduto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text))
            {
                MessageBox.Show("Informe o código de barras.");
                txtCodigoBarras.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Informe o preço do produto.");
                txtPreco.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEstoque.Text))
            {
                MessageBox.Show("Informe a quantidade em estoque.");
                txtEstoque.Focus();
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria.");
                cmbCategoria.Focus();
                return false;
            }

            if (!decimal.TryParse(
                txtPreco.Text.Trim(),
                System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.GetCultureInfo("pt-BR"),
                out decimal preco) || preco <= 0)
            {
                MessageBox.Show("Informe um preço válido e maior que zero.");
                txtPreco.Focus();
                return false;
            }

            if (!int.TryParse(txtEstoque.Text.Trim(), out int estoque) || estoque < 0)
            {
                MessageBox.Show("Informe uma quantidade de estoque válida.");
                txtEstoque.Focus();
                return false;
            }

            return true;
        }

        private bool CodigoBarrasExiste(string codigo, int idProdutoIgnorar = 0)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM produto
                WHERE codigo_barras = @codigo
                AND id_produto <> @id;
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                MessageBox.Show("Conexão aberta. Iniciando verificação do código.");

                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@id", idProdutoIgnorar);

                    int quantidade = Convert.ToInt32(comando.ExecuteScalar());

                    return quantidade > 0;
                }
            }
        }

        private void btnCadastrar_Click(object? sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (CodigoBarrasExiste(txtCodigoBarras.Text.Trim()))
            {
                MessageBox.Show("Já existe um produto cadastrado com este código de barras.");
                txtCodigoBarras.Focus();
                return;
            }

            string sql = @"
                INSERT INTO produto
                (id_categoria, codigo_barras, nome, preco, estoque, ativo)
                VALUES
                (@categoria, @codigo, @nome, @preco, @estoque, TRUE);
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@categoria", Convert.ToInt32(cmbCategoria.SelectedValue));
                    comando.Parameters.AddWithValue("@codigo", txtCodigoBarras.Text.Trim());
                    comando.Parameters.AddWithValue("@nome", txtNomeProduto.Text.Trim());
                    comando.Parameters.AddWithValue("@preco", Convert.ToDecimal(
                        txtPreco.Text.Trim(),
                        System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
                    ));
                    comando.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text.Trim()));

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Produto cadastrado com sucesso!",
                "Cadastro de Produtos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            CarregarProdutos();
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtCodigoBarras.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();

            cmbCategoria.SelectedIndex = -1;

            txtNomeProduto.Focus();
        }
        private void btnPesquisarProduto_Click(object? sender, EventArgs e)
        {
            string pesquisa = txtBuscarProduto.Text.Trim();

            CarregarProdutos(pesquisa);
        }

        private void dgvProdutosCadastrados_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow linha = dgvProdutosCadastrados.Rows[e.RowIndex];

            idProdutoSelecionado = Convert.ToInt32(linha.Cells["colIdProduto"].Value);

            txtCodigoBarras.Text = linha.Cells["colCodigoBarras"].Value?.ToString() ?? "";
            txtNomeProduto.Text = linha.Cells["colNomeProduto"].Value?.ToString() ?? "";
            txtPreco.Text = Convert.ToDecimal(
                linha.Cells["colPrecoProduto"].Value.ToString().Replace("R$", "").Trim(),
                System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
            ).ToString("0.00");

            txtEstoque.Text = linha.Cells["colEstoqueProduto"].Value?.ToString() ?? "";

            string categoria = linha.Cells["colCategoriaProduto"].Value?.ToString() ?? "";

            cmbCategoria.Text = categoria;
        }
        private void btnAtualizar_Click(object? sender, EventArgs e)
        {
            if (idProdutoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto na tabela para atualizar.");
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            if (CodigoBarrasExiste(txtCodigoBarras.Text.Trim(),idProdutoSelecionado.Value))
            {
                MessageBox.Show("Este código de barras já pertence a outro produto.");
                txtCodigoBarras.Focus();
                return;
            }

            string sql = @"
                UPDATE produto
                SET
                    id_categoria = @categoria,
                    codigo_barras = @codigo,
                    nome = @nome,
                    preco = @preco,
                    estoque = @estoque,
                    ativo = TRUE
                WHERE id_produto = @id;
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@categoria", Convert.ToInt32(cmbCategoria.SelectedValue));
                    comando.Parameters.AddWithValue("@codigo", txtCodigoBarras.Text.Trim());
                    comando.Parameters.AddWithValue("@nome", txtNomeProduto.Text.Trim());

                    comando.Parameters.AddWithValue("@preco", Convert.ToDecimal(
                        txtPreco.Text.Trim(),
                        System.Globalization.CultureInfo.GetCultureInfo("pt-BR")
                    ));

                    comando.Parameters.AddWithValue("@estoque", Convert.ToInt32(txtEstoque.Text.Trim()));
                    comando.Parameters.AddWithValue("@id", idProdutoSelecionado.Value);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Produto atualizado com sucesso!",
                "Cadastro de Produtos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            idProdutoSelecionado = null;

            CarregarProdutos();
            LimparCampos();
        }

        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            if (idProdutoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto na tabela para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                                        "Tem certeza de que deseja excluir este produto?",
                                        "Confirmar exclusão",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
            );

            if (resultado != DialogResult.Yes)
            {
                return;
            }

            string sql = @"
                UPDATE produto
                SET ativo = FALSE
                WHERE id_produto = @id
                AND ativo = TRUE;
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@id", idProdutoSelecionado.Value);

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas == 0)
                    {
                        MessageBox.Show("Este produto já está inativo.");

                        idProdutoSelecionado = null;
                        CarregarProdutos();
                        LimparCampos();

                        return;
                    }
                }
            }

            MessageBox.Show(
                "Produto excluído com sucesso!",
                "Cadastro de Produtos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            idProdutoSelecionado = null;

            CarregarProdutos();
            LimparCampos();
        }

        private void btnLimpar_Click(object? sender, EventArgs e)
        {
            idProdutoSelecionado = null;

            LimparCampos();

            dgvProdutosCadastrados.ClearSelection();
        }
        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
