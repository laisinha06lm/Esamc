using System.Runtime.InteropServices;

namespace Projeto_Final
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]

        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]

        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1Cabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }
        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                if (conexao.TestarConexao())
                {
                    MessageBox.Show("Conexão bem-sucedida com o banco de dados!");
                }
                else
                {
                    MessageBox.Show("Não foi possível conectar o Banco de Dados.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conexão: " + ex.Message);
            }
        }

        private void panel2Caixa_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2Caixa>();
        }

        private void panel5HistoricoVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3HistoricoVendas>();
        }

        private void panel3Produtos_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4Produtos>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4Estoque_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5Gerenciamento>();
        }
    }
}
