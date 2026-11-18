namespace Projeto_Final
{
    partial class Form4Produtos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1Cabecalho = new Panel();
            fechar = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            gbDadosProduto = new GroupBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnCadastrar = new Button();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblEstoque = new Label();
            lblPreco = new Label();
            lblCodigoBarras = new Label();
            txtEstoque = new TextBox();
            txtPreco = new TextBox();
            txtCodigoBarras = new TextBox();
            txtNomeProduto = new TextBox();
            label3lblNomeProduto = new Label();
            gbProdutosCadastrados = new GroupBox();
            btnPesquisarProduto = new Button();
            label3 = new Label();
            txtBuscarProduto = new TextBox();
            lblBuscarProduto = new Label();
            dgvProdutosCadastrados = new DataGridView();
            colIdProduto = new DataGridViewTextBoxColumn();
            colCodigoBarras = new DataGridViewTextBoxColumn();
            colNomeProduto = new DataGridViewTextBoxColumn();
            colCategoriaProduto = new DataGridViewTextBoxColumn();
            colPrecoProduto = new DataGridViewTextBoxColumn();
            colEstoqueProduto = new DataGridViewTextBoxColumn();
            colStatusProduto = new DataGridViewTextBoxColumn();
            panel1Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbDadosProduto.SuspendLayout();
            gbProdutosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutosCadastrados).BeginInit();
            SuspendLayout();
            // 
            // panel1Cabecalho
            // 
            panel1Cabecalho.BackColor = Color.FromArgb(0, 0, 192);
            panel1Cabecalho.Controls.Add(fechar);
            panel1Cabecalho.Controls.Add(label2);
            panel1Cabecalho.Controls.Add(label1);
            panel1Cabecalho.Controls.Add(pictureBox1);
            panel1Cabecalho.Location = new Point(1, 2);
            panel1Cabecalho.Name = "panel1Cabecalho";
            panel1Cabecalho.Size = new Size(949, 133);
            panel1Cabecalho.TabIndex = 0;
            panel1Cabecalho.MouseMove += panel1Cabecalho_MouseDown;
            // 
            // fechar
            // 
            fechar.BackColor = Color.Navy;
            fechar.FlatAppearance.BorderSize = 0;
            fechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            fechar.FlatAppearance.MouseOverBackColor = Color.Red;
            fechar.Image = Properties.Resources.gato_x_50x50;
            fechar.Location = new Point(845, 23);
            fechar.Name = "fechar";
            fechar.Size = new Size(93, 53);
            fechar.TabIndex = 3;
            fechar.UseVisualStyleBackColor = false;
            fechar.Click += fechar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 82);
            label2.Name = "label2";
            label2.Size = new Size(483, 28);
            label2.TabIndex = 2;
            label2.Text = "Gerencie os produtos disponíveis no SuperMarket";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(621, 63);
            label1.TabIndex = 1;
            label1.Text = "CADASTRO DE PRODUTOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shop_transparente_100x100;
            pictureBox1.Location = new Point(695, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gbDadosProduto
            // 
            gbDadosProduto.BackColor = Color.FromArgb(255, 192, 128);
            gbDadosProduto.Controls.Add(btnLimpar);
            gbDadosProduto.Controls.Add(btnExcluir);
            gbDadosProduto.Controls.Add(btnAtualizar);
            gbDadosProduto.Controls.Add(btnCadastrar);
            gbDadosProduto.Controls.Add(cmbCategoria);
            gbDadosProduto.Controls.Add(lblCategoria);
            gbDadosProduto.Controls.Add(lblEstoque);
            gbDadosProduto.Controls.Add(lblPreco);
            gbDadosProduto.Controls.Add(lblCodigoBarras);
            gbDadosProduto.Controls.Add(txtEstoque);
            gbDadosProduto.Controls.Add(txtPreco);
            gbDadosProduto.Controls.Add(txtCodigoBarras);
            gbDadosProduto.Controls.Add(txtNomeProduto);
            gbDadosProduto.Controls.Add(label3lblNomeProduto);
            gbDadosProduto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbDadosProduto.ForeColor = Color.Black;
            gbDadosProduto.Location = new Point(26, 145);
            gbDadosProduto.Name = "gbDadosProduto";
            gbDadosProduto.Size = new Size(896, 243);
            gbDadosProduto.TabIndex = 1;
            gbDadosProduto.TabStop = false;
            gbDadosProduto.Text = "Dados do Produto";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.FlatAppearance.BorderColor = Color.White;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.White;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLimpar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(745, 188);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 46);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Red;
            btnExcluir.FlatAppearance.BorderColor = Color.White;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.White;
            btnExcluir.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(518, 188);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 46);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.DodgerBlue;
            btnAtualizar.FlatAppearance.BorderColor = Color.White;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatAppearance.MouseDownBackColor = Color.White;
            btnAtualizar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAtualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(267, 188);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 46);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Lime;
            btnCadastrar.FlatAppearance.BorderColor = Color.White;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatAppearance.MouseDownBackColor = Color.White;
            btnCadastrar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnCadastrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(62, 188);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 46);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(425, 143);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(182, 36);
            cmbCategoria.TabIndex = 10;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(278, 143);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(101, 28);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(427, 91);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(226, 28);
            lblEstoque.TabIndex = 8;
            lblEstoque.Text = "Quantidade em estoque:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(40, 85);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(105, 28);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço (R$):";
            // 
            // lblCodigoBarras
            // 
            lblCodigoBarras.AutoSize = true;
            lblCodigoBarras.Location = new Point(454, 40);
            lblCodigoBarras.Name = "lblCodigoBarras";
            lblCodigoBarras.Size = new Size(167, 28);
            lblCodigoBarras.TabIndex = 6;
            lblCodigoBarras.Text = "Código de barras:";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(670, 85);
            txtEstoque.MaxLength = 20;
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(150, 34);
            txtEstoque.TabIndex = 4;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(199, 85);
            txtPreco.MaxLength = 20;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(150, 34);
            txtPreco.TabIndex = 3;
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(670, 37);
            txtCodigoBarras.MaxLength = 50;
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(150, 34);
            txtCodigoBarras.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(199, 40);
            txtNomeProduto.MaxLength = 100;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(150, 34);
            txtNomeProduto.TabIndex = 1;
            // 
            // label3lblNomeProduto
            // 
            label3lblNomeProduto.AutoSize = true;
            label3lblNomeProduto.Location = new Point(16, 40);
            label3lblNomeProduto.Name = "label3lblNomeProduto";
            label3lblNomeProduto.Size = new Size(177, 28);
            label3lblNomeProduto.TabIndex = 0;
            label3lblNomeProduto.Text = "Nome do produto:";
            // 
            // gbProdutosCadastrados
            // 
            gbProdutosCadastrados.BackColor = Color.FromArgb(255, 224, 192);
            gbProdutosCadastrados.Controls.Add(btnPesquisarProduto);
            gbProdutosCadastrados.Controls.Add(label3);
            gbProdutosCadastrados.Controls.Add(txtBuscarProduto);
            gbProdutosCadastrados.Controls.Add(lblBuscarProduto);
            gbProdutosCadastrados.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbProdutosCadastrados.Location = new Point(26, 399);
            gbProdutosCadastrados.Name = "gbProdutosCadastrados";
            gbProdutosCadastrados.Size = new Size(896, 133);
            gbProdutosCadastrados.TabIndex = 2;
            gbProdutosCadastrados.TabStop = false;
            gbProdutosCadastrados.Text = "Produtos Cadastrados";
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.BackColor = Color.FromArgb(255, 224, 192);
            btnPesquisarProduto.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarProduto.FlatAppearance.BorderColor = Color.White;
            btnPesquisarProduto.FlatAppearance.BorderSize = 0;
            btnPesquisarProduto.FlatAppearance.MouseDownBackColor = Color.White;
            btnPesquisarProduto.FlatAppearance.MouseOverBackColor = Color.Red;
            btnPesquisarProduto.Image = Properties.Resources.logo_transparente_50x50;
            btnPesquisarProduto.Location = new Point(369, 25);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(80, 65);
            btnPesquisarProduto.TabIndex = 3;
            btnPesquisarProduto.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(765, 20);
            label3.Name = "label3";
            label3.Size = new Size(122, 21);
            label3.TabIndex = 2;
            label3.Text = "Nome ou código";
            // 
            // txtBuscarProduto
            // 
            txtBuscarProduto.Location = new Point(213, 40);
            txtBuscarProduto.MaxLength = 150;
            txtBuscarProduto.Name = "txtBuscarProduto";
            txtBuscarProduto.Size = new Size(150, 34);
            txtBuscarProduto.TabIndex = 1;
            // 
            // lblBuscarProduto
            // 
            lblBuscarProduto.AutoSize = true;
            lblBuscarProduto.Location = new Point(16, 40);
            lblBuscarProduto.Name = "lblBuscarProduto";
            lblBuscarProduto.Size = new Size(175, 28);
            lblBuscarProduto.TabIndex = 0;
            lblBuscarProduto.Text = "Pesquisar produto:";
            // 
            // dgvProdutosCadastrados
            // 
            dgvProdutosCadastrados.AllowUserToAddRows = false;
            dgvProdutosCadastrados.AllowUserToDeleteRows = false;
            dgvProdutosCadastrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutosCadastrados.BackgroundColor = Color.White;
            dgvProdutosCadastrados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutosCadastrados.Columns.AddRange(new DataGridViewColumn[] { colIdProduto, colCodigoBarras, colNomeProduto, colCategoriaProduto, colPrecoProduto, colEstoqueProduto, colStatusProduto });
            dgvProdutosCadastrados.Location = new Point(1, 546);
            dgvProdutosCadastrados.MultiSelect = false;
            dgvProdutosCadastrados.Name = "dgvProdutosCadastrados";
            dgvProdutosCadastrados.ReadOnly = true;
            dgvProdutosCadastrados.RowHeadersVisible = false;
            dgvProdutosCadastrados.RowHeadersWidth = 62;
            dgvProdutosCadastrados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutosCadastrados.Size = new Size(949, 307);
            dgvProdutosCadastrados.TabIndex = 3;
            // 
            // colIdProduto
            // 
            colIdProduto.HeaderText = "ID";
            colIdProduto.MinimumWidth = 8;
            colIdProduto.Name = "colIdProduto";
            colIdProduto.ReadOnly = true;
            // 
            // colCodigoBarras
            // 
            colCodigoBarras.HeaderText = "Código de barras";
            colCodigoBarras.MinimumWidth = 8;
            colCodigoBarras.Name = "colCodigoBarras";
            colCodigoBarras.ReadOnly = true;
            // 
            // colNomeProduto
            // 
            colNomeProduto.HeaderText = "Produto";
            colNomeProduto.MinimumWidth = 8;
            colNomeProduto.Name = "colNomeProduto";
            colNomeProduto.ReadOnly = true;
            // 
            // colCategoriaProduto
            // 
            colCategoriaProduto.HeaderText = "Categoria";
            colCategoriaProduto.MinimumWidth = 8;
            colCategoriaProduto.Name = "colCategoriaProduto";
            colCategoriaProduto.ReadOnly = true;
            // 
            // colPrecoProduto
            // 
            colPrecoProduto.HeaderText = "Preço";
            colPrecoProduto.MinimumWidth = 8;
            colPrecoProduto.Name = "colPrecoProduto";
            colPrecoProduto.ReadOnly = true;
            // 
            // colEstoqueProduto
            // 
            colEstoqueProduto.HeaderText = "Estoque";
            colEstoqueProduto.MinimumWidth = 8;
            colEstoqueProduto.Name = "colEstoqueProduto";
            colEstoqueProduto.ReadOnly = true;
            // 
            // colStatusProduto
            // 
            colStatusProduto.HeaderText = "Status";
            colStatusProduto.MinimumWidth = 8;
            colStatusProduto.Name = "colStatusProduto";
            colStatusProduto.ReadOnly = true;
            // 
            // Form4Produtos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(951, 861);
            Controls.Add(dgvProdutosCadastrados);
            Controls.Add(gbProdutosCadastrados);
            Controls.Add(gbDadosProduto);
            Controls.Add(panel1Cabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4Produtos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4Produtos";
            panel1Cabecalho.ResumeLayout(false);
            panel1Cabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbDadosProduto.ResumeLayout(false);
            gbDadosProduto.PerformLayout();
            gbProdutosCadastrados.ResumeLayout(false);
            gbProdutosCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutosCadastrados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1Cabecalho;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox gbDadosProduto;
        private TextBox txtNomeProduto;
        private Label label3lblNomeProduto;
        private Label lblCategoria;
        private Label lblEstoque;
        private Label lblPreco;
        private Label lblCodigoBarras;
        private TextBox txtEstoque;
        private TextBox txtPreco;
        private TextBox txtCodigoBarras;
        private ComboBox cmbCategoria;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnCadastrar;
        private GroupBox gbProdutosCadastrados;
        private Label label3;
        private TextBox txtBuscarProduto;
        private Label lblBuscarProduto;
        private Button btnPesquisarProduto;
        private DataGridView dgvProdutosCadastrados;
        private DataGridViewTextBoxColumn colIdProduto;
        private DataGridViewTextBoxColumn colCodigoBarras;
        private DataGridViewTextBoxColumn colNomeProduto;
        private DataGridViewTextBoxColumn colCategoriaProduto;
        private DataGridViewTextBoxColumn colPrecoProduto;
        private DataGridViewTextBoxColumn colEstoqueProduto;
        private DataGridViewTextBoxColumn colStatusProduto;
        private Button fechar;
    }
}