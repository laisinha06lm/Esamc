namespace Projeto_Final
{
    partial class Form2Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Caixa));
            panel1Cabecalho = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtBuscarProduto = new Panel();
            label5 = new Label();
            dgvProdutos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colProduto = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colEstoque = new DataGridViewTextBoxColumn();
            btnBuscarProduto = new Button();
            textBuscarProduto = new TextBox();
            label4 = new Label();
            pnlItensVenda = new Panel();
            btnLimpar = new Button();
            dgvItensVenda = new DataGridView();
            colItemCodigo = new DataGridViewTextBoxColumn();
            colItemProduto = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colValorUnitario = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            label6 = new Label();
            btnRemover = new Button();
            btnAdicionar = new Button();
            pnlResumo = new Panel();
            label12 = new Label();
            txtDescontoPercentual = new TextBox();
            label11 = new Label();
            cmbFormaPagamento = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            btnCancelarVenda = new Button();
            btnFinalizarVenda = new Button();
            lblTotal = new Label();
            lblDesconto = new Label();
            lblSubtotal = new Label();
            label7 = new Label();
            panel1Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            txtBuscarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            pnlItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            pnlResumo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1Cabecalho
            // 
            panel1Cabecalho.BackColor = Color.Navy;
            panel1Cabecalho.Controls.Add(button1);
            panel1Cabecalho.Controls.Add(pictureBox2);
            panel1Cabecalho.Controls.Add(label3);
            panel1Cabecalho.Controls.Add(label2);
            panel1Cabecalho.Controls.Add(pictureBox1);
            panel1Cabecalho.Controls.Add(label1);
            panel1Cabecalho.Location = new Point(0, -1);
            panel1Cabecalho.Name = "panel1Cabecalho";
            panel1Cabecalho.Size = new Size(800, 163);
            panel1Cabecalho.TabIndex = 0;
            panel1Cabecalho.MouseMove += panel1Cabecalho_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Navy;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Image = Properties.Resources.gato_x_50x50;
            button1.Location = new Point(676, 23);
            button1.Name = "button1";
            button1.Size = new Size(112, 61);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.shop_transparente_100x100;
            pictureBox2.Location = new Point(537, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 89);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 122);
            label3.Name = "label3";
            label3.Size = new Size(237, 21);
            label3.TabIndex = 2;
            label3.Text = "Qualidade e economia sempre!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 84);
            label2.Name = "label2";
            label2.Size = new Size(266, 28);
            label2.TabIndex = 1;
            label2.Text = "CAIXA • Sistema de vendas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 51);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(303, 67);
            label1.TabIndex = 0;
            label1.Text = "SuperMarket";
            // 
            // txtBuscarProduto
            // 
            txtBuscarProduto.BackColor = Color.White;
            txtBuscarProduto.Controls.Add(label5);
            txtBuscarProduto.Controls.Add(dgvProdutos);
            txtBuscarProduto.Controls.Add(btnBuscarProduto);
            txtBuscarProduto.Controls.Add(textBuscarProduto);
            txtBuscarProduto.Controls.Add(label4);
            txtBuscarProduto.Location = new Point(0, 161);
            txtBuscarProduto.Name = "txtBuscarProduto";
            txtBuscarProduto.Size = new Size(800, 237);
            txtBuscarProduto.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 93);
            label5.Name = "label5";
            label5.Size = new Size(273, 32);
            label5.TabIndex = 4;
            label5.Text = "2. Produtos encontrados\n";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = Color.White;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProduto, colPreco, colEstoque });
            dgvProdutos.Location = new Point(0, 128);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersWidth = 62;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(800, 109);
            dgvProdutos.TabIndex = 3;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 8;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colProduto
            // 
            colProduto.HeaderText = "Produto";
            colProduto.MinimumWidth = 8;
            colProduto.Name = "colProduto";
            colProduto.ReadOnly = true;
            // 
            // colPreco
            // 
            colPreco.HeaderText = "Preço";
            colPreco.MinimumWidth = 8;
            colPreco.Name = "colPreco";
            colPreco.ReadOnly = true;
            // 
            // colEstoque
            // 
            colEstoque.HeaderText = "Estoque";
            colEstoque.MinimumWidth = 8;
            colEstoque.Name = "colEstoque";
            colEstoque.ReadOnly = true;
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.FlatAppearance.BorderSize = 0;
            btnBuscarProduto.FlatAppearance.MouseDownBackColor = Color.Fuchsia;
            btnBuscarProduto.FlatAppearance.MouseOverBackColor = Color.Fuchsia;
            btnBuscarProduto.Image = Properties.Resources.lupa_coracao_transparente_50x50;
            btnBuscarProduto.Location = new Point(727, 43);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.Size = new Size(52, 44);
            btnBuscarProduto.TabIndex = 3;
            btnBuscarProduto.UseVisualStyleBackColor = true;
            btnBuscarProduto.Click += btnBuscarProduto_Click;
            // 
            // textBuscarProduto
            // 
            textBuscarProduto.Location = new Point(3, 50);
            textBuscarProduto.Name = "textBuscarProduto";
            textBuscarProduto.PlaceholderText = "Digite o nome ou código do produto...";
            textBuscarProduto.Size = new Size(776, 31);
            textBuscarProduto.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(201, 32);
            label4.TabIndex = 0;
            label4.Text = "1. Buscar produto";
            // 
            // pnlItensVenda
            // 
            pnlItensVenda.BackColor = Color.White;
            pnlItensVenda.BorderStyle = BorderStyle.FixedSingle;
            pnlItensVenda.Controls.Add(btnLimpar);
            pnlItensVenda.Controls.Add(dgvItensVenda);
            pnlItensVenda.Controls.Add(label6);
            pnlItensVenda.Controls.Add(btnRemover);
            pnlItensVenda.Controls.Add(btnAdicionar);
            pnlItensVenda.Location = new Point(0, 388);
            pnlItensVenda.Name = "pnlItensVenda";
            pnlItensVenda.Size = new Size(800, 344);
            pnlItensVenda.TabIndex = 3;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.FlatAppearance.BorderColor = Color.White;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.Black;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(675, 301);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.AllowUserToAddRows = false;
            dgvItensVenda.AllowUserToDeleteRows = false;
            dgvItensVenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensVenda.BackgroundColor = Color.White;
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensVenda.Columns.AddRange(new DataGridViewColumn[] { colItemCodigo, colItemProduto, colQuantidade, colValorUnitario, colSubtotal });
            dgvItensVenda.Location = new Point(-1, 38);
            dgvItensVenda.MultiSelect = false;
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.ReadOnly = true;
            dgvItensVenda.RowHeadersWidth = 62;
            dgvItensVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensVenda.Size = new Size(800, 257);
            dgvItensVenda.TabIndex = 1;
            // 
            // colItemCodigo
            // 
            colItemCodigo.HeaderText = "Código";
            colItemCodigo.MinimumWidth = 8;
            colItemCodigo.Name = "colItemCodigo";
            colItemCodigo.ReadOnly = true;
            // 
            // colItemProduto
            // 
            colItemProduto.HeaderText = "Produto";
            colItemProduto.MinimumWidth = 8;
            colItemProduto.Name = "colItemProduto";
            colItemProduto.ReadOnly = true;
            // 
            // colQuantidade
            // 
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.MinimumWidth = 8;
            colQuantidade.Name = "colQuantidade";
            colQuantidade.ReadOnly = true;
            // 
            // colValorUnitario
            // 
            colValorUnitario.HeaderText = "Valor Unitário";
            colValorUnitario.MinimumWidth = 8;
            colValorUnitario.Name = "colValorUnitario";
            colValorUnitario.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(2, 3);
            label6.Name = "label6";
            label6.Size = new Size(195, 32);
            label6.TabIndex = 0;
            label6.Text = "3. Itens da venda";
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(255, 128, 128);
            btnRemover.FlatAppearance.BorderColor = Color.White;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatAppearance.MouseDownBackColor = Color.Red;
            btnRemover.FlatAppearance.MouseOverBackColor = Color.Red;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.Location = new Point(546, 301);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 34);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(128, 128, 255);
            btnAdicionar.FlatAppearance.BorderColor = Color.Navy;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnAdicionar.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(418, 301);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // pnlResumo
            // 
            pnlResumo.BackColor = Color.White;
            pnlResumo.BorderStyle = BorderStyle.FixedSingle;
            pnlResumo.Controls.Add(label12);
            pnlResumo.Controls.Add(txtDescontoPercentual);
            pnlResumo.Controls.Add(label11);
            pnlResumo.Controls.Add(cmbFormaPagamento);
            pnlResumo.Controls.Add(label10);
            pnlResumo.Controls.Add(label9);
            pnlResumo.Controls.Add(label8);
            pnlResumo.Controls.Add(btnCancelarVenda);
            pnlResumo.Controls.Add(btnFinalizarVenda);
            pnlResumo.Controls.Add(lblTotal);
            pnlResumo.Controls.Add(lblDesconto);
            pnlResumo.Controls.Add(lblSubtotal);
            pnlResumo.Controls.Add(label7);
            pnlResumo.Location = new Point(0, 730);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(800, 264);
            pnlResumo.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(403, 96);
            label12.Name = "label12";
            label12.Size = new Size(202, 25);
            label12.TabIndex = 12;
            label12.Text = "Percentual de Desconto:";
            // 
            // txtDescontoPercentual
            // 
            txtDescontoPercentual.Location = new Point(630, 96);
            txtDescontoPercentual.MaxLength = 5;
            txtDescontoPercentual.Name = "txtDescontoPercentual";
            txtDescontoPercentual.Size = new Size(91, 31);
            txtDescontoPercentual.TabIndex = 11;
            txtDescontoPercentual.Text = "0";
            txtDescontoPercentual.TextAlign = HorizontalAlignment.Center;
            txtDescontoPercentual.TextChanged += txtDescontoPercentual_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(403, 49);
            label11.Name = "label11";
            label11.Size = new Size(187, 25);
            label11.TabIndex = 10;
            label11.Text = "Forma de Pagamento:";
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormaPagamento.FormattingEnabled = true;
            cmbFormaPagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartão de débito", "Cartão de crédito" });
            cmbFormaPagamento.Location = new Point(596, 46);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(182, 33);
            cmbFormaPagamento.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 74);
            label10.Name = "label10";
            label10.Size = new Size(92, 25);
            label10.TabIndex = 8;
            label10.Text = "Desconto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 49);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 7;
            label9.Text = "Subtotal:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 120);
            label8.Name = "label8";
            label8.Size = new Size(85, 32);
            label8.TabIndex = 6;
            label8.Text = "TOTAL:";
            // 
            // btnCancelarVenda
            // 
            btnCancelarVenda.BackColor = Color.Red;
            btnCancelarVenda.FlatStyle = FlatStyle.Flat;
            btnCancelarVenda.ForeColor = Color.White;
            btnCancelarVenda.Image = (Image)resources.GetObject("btnCancelarVenda.Image");
            btnCancelarVenda.ImageAlign = ContentAlignment.TopCenter;
            btnCancelarVenda.Location = new Point(478, 155);
            btnCancelarVenda.Name = "btnCancelarVenda";
            btnCancelarVenda.Size = new Size(259, 91);
            btnCancelarVenda.TabIndex = 5;
            btnCancelarVenda.Text = "CANCELAR VENDA";
            btnCancelarVenda.TextAlign = ContentAlignment.BottomCenter;
            btnCancelarVenda.UseVisualStyleBackColor = false;
            btnCancelarVenda.Click += btnCancelarVenda_Click;
            // 
            // btnFinalizarVenda
            // 
            btnFinalizarVenda.BackColor = Color.Green;
            btnFinalizarVenda.FlatStyle = FlatStyle.Flat;
            btnFinalizarVenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenda.ForeColor = Color.White;
            btnFinalizarVenda.Image = (Image)resources.GetObject("btnFinalizarVenda.Image");
            btnFinalizarVenda.ImageAlign = ContentAlignment.TopCenter;
            btnFinalizarVenda.Location = new Point(100, 155);
            btnFinalizarVenda.Name = "btnFinalizarVenda";
            btnFinalizarVenda.Size = new Size(259, 91);
            btnFinalizarVenda.TabIndex = 4;
            btnFinalizarVenda.Text = "FINALIZAR VENDA";
            btnFinalizarVenda.TextAlign = ContentAlignment.BottomCenter;
            btnFinalizarVenda.UseVisualStyleBackColor = false;
            btnFinalizarVenda.Click += btnFinalizarVenda_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(84, 120);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 32);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "R$ 0,00";
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Location = new Point(88, 74);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(72, 25);
            lblDesconto.TabIndex = 2;
            lblDesconto.Text = "R$ 0,00";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(88, 49);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(72, 25);
            lblSubtotal.TabIndex = 1;
            lblSubtotal.Text = "R$ 0,00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(244, 32);
            label7.TabIndex = 0;
            label7.Text = "4. Resumo da compra";
            // 
            // Form2Caixa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 994);
            Controls.Add(pnlResumo);
            Controls.Add(pnlItensVenda);
            Controls.Add(txtBuscarProduto);
            Controls.Add(panel1Cabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2Caixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1Cabecalho.ResumeLayout(false);
            panel1Cabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            txtBuscarProduto.ResumeLayout(false);
            txtBuscarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            pnlItensVenda.ResumeLayout(false);
            pnlItensVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            pnlResumo.ResumeLayout(false);
            pnlResumo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1Cabecalho;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel txtBuscarProduto;
        private TextBox textBuscarProduto;
        private Label label4;
        private Button btnBuscarProduto;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colProduto;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colEstoque;
        private Label label5;
        private Panel pnlItensVenda;
        private DataGridView dgvItensVenda;
        private Label label6;
        private DataGridViewTextBoxColumn colItemCodigo;
        private DataGridViewTextBoxColumn colItemProduto;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colValorUnitario;
        private DataGridViewTextBoxColumn colSubtotal;
        private Panel pnlResumo;
        private Label label7;
        private Label lblTotal;
        private Label lblDesconto;
        private Label lblSubtotal;
        private Button btnFinalizarVenda;
        private Button btnCancelarVenda;
        private Button btnLimpar;
        private Button btnRemover;
        private Button btnAdicionar;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private ComboBox cmbFormaPagamento;
        private TextBox txtDescontoPercentual;
        private Label label12;
        private PictureBox pictureBox2;
        private Button button1;
    }
}