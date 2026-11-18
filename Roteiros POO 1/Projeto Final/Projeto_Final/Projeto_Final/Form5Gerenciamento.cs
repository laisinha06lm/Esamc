
using Npgsql;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class Form5Gerenciamento : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            IntPtr hwnd, int msg, int wParam, int lParam
        );

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool carregandoFiltros = false;

        public Form5Gerenciamento()
        {
            InitializeComponent();

            this.Load += Form5Gerenciamento_Load;

            btnPesquisa.Click += btnPesquisa_Click;
            btnBuscarProduto.Click += btnBuscaProduto_Click;

            comboBoxFiltrar.SelectedIndexChanged +=
                comboBoxFiltrar_SelectedIndexChanged;

            btnLimpar.Click += btnLimpar_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1Cabecalho_MouseDown(
            object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(
                    this.Handle,
                    WM_NCLBUTTONDOWN,
                    HT_CAPTION,
                    0
                );
            }
        }
        private void Form5Gerenciamento_Load(
            object? sender, EventArgs e)
        {
            try
            {
                carregandoFiltros = true;

                CarregarCategorias();

                carregandoFiltros = false;

                CarregarProdutos();
            }
            catch (Exception ex)
            {
                carregandoFiltros = false;

                MessageBox.Show(
                    "Erro ao carregar o estoque: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void CarregarCategorias()
        {
            DataTable tabela = new DataTable();

            tabela.Columns.Add("id_categoria", typeof(int));
            tabela.Columns.Add("nome", typeof(string));

            tabela.Rows.Add(0, "Todas as categorias");

            using (var conexao = new Conexao().AbrirConexao())
            using (var comando = new NpgsqlCommand(
                @"SELECT id_categoria, nome
                  FROM categoria
                  WHERE ativa = TRUE
                  ORDER BY nome;",
                conexao))
            using (var leitor = comando.ExecuteReader())
            {
                while (leitor.Read())
                {
                    tabela.Rows.Add(
                        leitor.GetInt32(0),
                        leitor.GetString(1)
                    );
                }
            }

            comboBoxFiltrar.DisplayMember = "nome";
            comboBoxFiltrar.ValueMember = "id_categoria";
            comboBoxFiltrar.DataSource = tabela;
        }
        private void CarregarProdutos()
        {
            int categoriaId = 0;

            if (comboBoxFiltrar.SelectedValue != null)
            {
                int.TryParse(
                    comboBoxFiltrar.SelectedValue.ToString(),
                    out categoriaId
                );
            }

            string busca = textBuscarProduto.Text.Trim();

            string sql = @"
                SELECT
                    p.nome AS ""Produto"",
                    COALESCE(c.nome, 'Sem categoria') AS ""Categoria"",
                    p.estoque AS ""Quantidade"",
                    p.preco AS ""Preco"",
                    CASE
                        WHEN p.estoque = 0 THEN 'Sem estoque'
                        WHEN p.estoque <= 5 THEN 'Estoque baixo'
                        ELSE 'Normal'
                    END AS ""Situacao""
                FROM produto p
                LEFT JOIN categoria c
                    ON p.id_categoria = c.id_categoria
                WHERE
                    p.ativo = TRUE
                    AND (
                        @categoria = 0
                        OR p.id_categoria = @categoria
                    )
                    AND (
                        @busca = ''
                        OR p.nome ILIKE @busca
                        OR COALESCE(p.codigo_barras, '') ILIKE @busca
                    )
                ORDER BY p.nome;
            ";

            using (var conexao = new Conexao().AbrirConexao())
            using (var comando = new NpgsqlCommand(sql, conexao))
            {
                comando.Parameters.AddWithValue(
                    "@categoria", categoriaId
                );

                comando.Parameters.AddWithValue(
                    "@busca", "%" + busca + "%"
                );

                DataTable tabela = new DataTable();

                using (var leitor = comando.ExecuteReader())
                {
                    tabela.Load(leitor);
                }

                dataGridEstoque.AutoGenerateColumns = false;

                dataGridEstoque.Columns["tblProduto"].DataPropertyName =
                    "Produto";

                dataGridEstoque.Columns["tblCategoria"].DataPropertyName =
                    "Categoria";

                dataGridEstoque.Columns["tblQuantidade"].DataPropertyName =
                    "Quantidade";

                dataGridEstoque.Columns["tblPreco"].DataPropertyName =
                    "Preco";

                dataGridEstoque.Columns["tblSituacao"].DataPropertyName =
                    "Situacao";

                dataGridEstoque.Columns["tblPreco"]
                    .DefaultCellStyle.Format = "C2";

                dataGridEstoque.Columns["tblQuantidade"]
                    .DefaultCellStyle.Format = "N0";

                dataGridEstoque.DataSource = tabela;
            }
        }
        private void btnPesquisa_Click(
            object? sender, EventArgs e)
        {
            PesquisarProdutos();
        }
        private void btnBuscaProduto_Click(
            object? sender, EventArgs e)
        {
            PesquisarProdutos();
        }

        private void PesquisarProdutos()
        {
            try
            {
                CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao pesquisar produtos: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void comboBoxFiltrar_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (!carregandoFiltros)
            {
                try
                {
                    CarregarProdutos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Erro ao filtrar produtos: " + ex.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnLimpar_Click(object? sender, EventArgs e)
        {
            textBuscarProduto.Clear();

            comboBoxFiltrar.SelectedValue = 0;

            CarregarProdutos();
        }
    }
}
