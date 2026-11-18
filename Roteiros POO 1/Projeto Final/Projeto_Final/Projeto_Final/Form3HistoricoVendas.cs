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
    public partial class Form3HistoricoVendas : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form3HistoricoVendas()
        {
            InitializeComponent();

            CarregarHistoricoVendas();

            btnPesquisar.Click += btnPesquisar_Click;

            btnLimparFiltros.Click += btnLimparFiltros_Click;

            dgvHistoricoVendas.SelectionChanged += dgvHistoricoVendas_SelectionChanged;
        }
        private void panel1Cabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void CarregarHistoricoVendas(int? filtroIdVenda = null, DateTime? dataInicial = null, DateTime? dataFinal = null)
        {
            string sql = @"
                SELECT
                    id_venda,
                    data_hora,
                    subtotal,
                    percentual_desconto,
                    valor_desconto,
                    valor_total,
                    forma_pagamento,
                    status
                FROM venda
            ";

            List<string> condicoes = new List<string>();

            if (filtroIdVenda.HasValue)
            {
                condicoes.Add("id_venda = @idVenda");
            }

            if (dataInicial.HasValue)
            {
                condicoes.Add("data_hora >= @dataInicial");
            }

            if (dataFinal.HasValue)
            {
                condicoes.Add("data_hora < @dataFinal");
            }

            if (condicoes.Count > 0)
            {
                sql += " WHERE " + string.Join(" AND ", condicoes);
            }

            sql += " ORDER BY id_venda DESC;";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    if (filtroIdVenda.HasValue)
                    {
                        comando.Parameters.AddWithValue("@idVenda", filtroIdVenda.Value);
                    }

                    if (dataInicial.HasValue)
                    {
                        comando.Parameters.AddWithValue("@dataInicial", dataInicial.Value.Date);
                    }

                    if (dataFinal.HasValue)
                    {
                        comando.Parameters.AddWithValue("@dataFinal", dataFinal.Value.Date.AddDays(1));
                    }

                    decimal totalVendido = 0;

                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        dgvHistoricoVendas.Rows.Clear();

                        dgvHistoricoVendas.ClearSelection();

                        lblVendasEncontradas.Text = "Vendas encontradas: 0";

                        while (leitor.Read())
                        {
                            int idVenda = leitor.GetInt32(0);

                            string dataHora = Convert.ToDateTime(leitor["data_hora"])
                                .ToString("dd/MM/yyyy HH:mm");

                            string subtotal = leitor.IsDBNull(2)
                                ? "—"
                                : Convert.ToDecimal(leitor["subtotal"]).ToString("C2");

                            string percentualDesconto = leitor.IsDBNull(3)
                                ? "—"
                                : Convert.ToDecimal(leitor["percentual_desconto"]).ToString("N2") + "%";

                            string valorDesconto = leitor.IsDBNull(4)
                                ? "—"
                                : Convert.ToDecimal(leitor["valor_desconto"]).ToString("C2");

                            string valorTotal = Convert.ToDecimal(leitor["valor_total"]).ToString("C2");

                            totalVendido += Convert.ToDecimal(leitor["valor_total"]);

                            string formaPagamento = leitor["forma_pagamento"].ToString() ?? "";

                            string status = leitor["status"].ToString() ?? "";

                            dgvHistoricoVendas.Rows.Add(
                                idVenda,
                                dataHora,
                                subtotal,
                                percentualDesconto,
                                valorDesconto,
                                valorTotal,
                                formaPagamento,
                                status
                            );

                            lblVendasEncontradas.Text =
                                $"Vendas encontradas: {dgvHistoricoVendas.Rows.Count}";
                        }

                        lblTotalVendido.Text = $"Valor total vendido: {totalVendido:C2}";

                        dgvHistoricoVendas.ClearSelection();
                    }
                }
            }
        }
        private void btnPesquisar_Click(object? sender, EventArgs e)
        {
            string idTexto = txtIdVenda.Text.Trim();

            int? filtroIdVenda = null;

            if (!string.IsNullOrWhiteSpace(idTexto))
            {
                if (!int.TryParse(idTexto, out int idVenda) || idVenda <= 0)
                {
                    MessageBox.Show("Informe um número de venda válido.");
                    return;
                }

                filtroIdVenda = idVenda;
            }

            DateTime? dataInicial = dtpDataInicial.Checked
                ? dtpDataInicial.Value.Date
                : null;

            DateTime? dataFinal = dtpDataFinal.Checked
                ? dtpDataFinal.Value.Date
                : null;

            if (dataInicial.HasValue && dataFinal.HasValue &&
                dataInicial.Value > dataFinal.Value)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.");
                return;
            }

            CarregarHistoricoVendas(filtroIdVenda, dataInicial, dataFinal);
        }
        private void btnLimparFiltros_Click(object? sender, EventArgs e)
        {
            txtIdVenda.Clear();

            dtpDataInicial.Checked = false;
            dtpDataFinal.Checked = false;

            CarregarHistoricoVendas();
        }
        private void dgvHistoricoVendas_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvHistoricoVendas.SelectedRows.Count == 0)
            {
                dgvItensHistorico.Rows.Clear();
                return;
            }

            int idVenda = Convert.ToInt32(
                dgvHistoricoVendas.SelectedRows[0].Cells["colIdVenda"].Value
            );

            CarregarItensVenda(idVenda);
        }

        private void CarregarItensVenda(int idVenda)
        {
            string sql = @"
                SELECT
                    p.codigo_barras,
                    p.nome,
                    iv.quantidade,
                    iv.preco_unitario,
                    iv.subtotal
                FROM item_venda iv
                INNER JOIN produto p ON p.id_produto = iv.id_produto
                WHERE iv.id_venda = @idVenda
                ORDER BY iv.id_item;
            ";

            using (NpgsqlConnection conexao = new Conexao().AbrirConexao())
            {
                using (NpgsqlCommand comando = new NpgsqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@idVenda", idVenda);

                    using (NpgsqlDataReader leitor = comando.ExecuteReader())
                    {
                        dgvItensHistorico.Rows.Clear();

                        while (leitor.Read())
                        {
                            string codigo = leitor["codigo_barras"].ToString() ?? "";
                            string nome = leitor["nome"].ToString() ?? "";

                            int quantidade = Convert.ToInt32(leitor["quantidade"]);

                            string precoUnitario = Convert.ToDecimal(leitor["preco_unitario"])
                                .ToString("C2");

                            string subtotal = Convert.ToDecimal(leitor["subtotal"])
                                .ToString("C2");

                            dgvItensHistorico.Rows.Add(
                                codigo,
                                nome,
                                quantidade,
                                precoUnitario,
                                subtotal
                            );
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
