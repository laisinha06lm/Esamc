namespace Projeto_Final
{
    partial class Form5Gerenciamento
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1Cabecalho = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBuscarProduto = new TextBox();
            label4 = new Label();
            comboBoxFiltrar = new ComboBox();
            label5 = new Label();
            dataGridEstoque = new DataGridView();
            tblProduto = new DataGridViewTextBoxColumn();
            tblCategoria = new DataGridViewTextBoxColumn();
            tblQuantidade = new DataGridViewTextBoxColumn();
            tblPreco = new DataGridViewTextBoxColumn();
            tblSituacao = new DataGridViewTextBoxColumn();
            btnPesquisa = new Button();
            btnBuscarProduto = new Button();
            btnLimpar = new Button();
            panel1Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstoque).BeginInit();
            SuspendLayout();
            // 
            // panel1Cabecalho
            // 
            panel1Cabecalho.BackColor = Color.Navy;
            panel1Cabecalho.Controls.Add(pictureBox1);
            panel1Cabecalho.Controls.Add(button1);
            panel1Cabecalho.Controls.Add(label2);
            panel1Cabecalho.Controls.Add(label1);
            panel1Cabecalho.Dock = DockStyle.Top;
            panel1Cabecalho.Location = new Point(0, 0);
            panel1Cabecalho.Name = "panel1Cabecalho";
            panel1Cabecalho.Size = new Size(871, 148);
            panel1Cabecalho.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_transparente_50x50;
            pictureBox1.Location = new Point(529, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 63);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Image = Properties.Resources.gato_x_50x50;
            button1.Location = new Point(752, 14);
            button1.Name = "button1";
            button1.Size = new Size(98, 68);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(454, 54);
            label2.TabIndex = 1;
            label2.Text = "Organização do Estoque";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 63);
            label1.TabIndex = 0;
            label1.Text = "SuperMarket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 162);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 1;
            label3.Text = "Buscar Produto";
            // 
            // textBuscarProduto
            // 
            textBuscarProduto.Location = new Point(36, 217);
            textBuscarProduto.Name = "textBuscarProduto";
            textBuscarProduto.Size = new Size(330, 31);
            textBuscarProduto.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(26, 275);
            label4.Name = "label4";
            label4.Size = new Size(246, 32);
            label4.TabIndex = 3;
            label4.Text = "Filtrar por Categoria";
            // 
            // comboBoxFiltrar
            // 
            comboBoxFiltrar.FormattingEnabled = true;
            comboBoxFiltrar.Location = new Point(312, 274);
            comboBoxFiltrar.Name = "comboBoxFiltrar";
            comboBoxFiltrar.Size = new Size(182, 33);
            comboBoxFiltrar.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 352);
            label5.Name = "label5";
            label5.Size = new Size(266, 32);
            label5.TabIndex = 5;
            label5.Text = "Produtos Cadastrados";
            // 
            // dataGridEstoque
            // 
            dataGridEstoque.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstoque.Columns.AddRange(new DataGridViewColumn[] { tblProduto, tblCategoria, tblQuantidade, tblPreco, tblSituacao });
            dataGridEstoque.Location = new Point(36, 417);
            dataGridEstoque.Name = "dataGridEstoque";
            dataGridEstoque.RowHeadersWidth = 62;
            dataGridEstoque.Size = new Size(814, 205);
            dataGridEstoque.TabIndex = 6;
            // 
            // tblProduto
            // 
            tblProduto.HeaderText = "Produto";
            tblProduto.MinimumWidth = 8;
            tblProduto.Name = "tblProduto";
            tblProduto.Width = 150;
            // 
            // tblCategoria
            // 
            tblCategoria.HeaderText = "Categoria";
            tblCategoria.MinimumWidth = 8;
            tblCategoria.Name = "tblCategoria";
            tblCategoria.Width = 150;
            // 
            // tblQuantidade
            // 
            tblQuantidade.HeaderText = "Quantidade";
            tblQuantidade.MinimumWidth = 8;
            tblQuantidade.Name = "tblQuantidade";
            tblQuantidade.Width = 150;
            // 
            // tblPreco
            // 
            tblPreco.HeaderText = "Preço";
            tblPreco.MinimumWidth = 8;
            tblPreco.Name = "tblPreco";
            tblPreco.Width = 150;
            // 
            // tblSituacao
            // 
            tblSituacao.HeaderText = "Situação";
            tblSituacao.MinimumWidth = 8;
            tblSituacao.Name = "tblSituacao";
            tblSituacao.Width = 150;
            // 
            // btnPesquisa
            // 
            btnPesquisa.BackColor = Color.Navy;
            btnPesquisa.FlatAppearance.BorderColor = Color.White;
            btnPesquisa.FlatAppearance.BorderSize = 0;
            btnPesquisa.FlatAppearance.MouseDownBackColor = Color.White;
            btnPesquisa.FlatAppearance.MouseOverBackColor = Color.Red;
            btnPesquisa.Image = Properties.Resources.image_transparente_50x50__1_;
            btnPesquisa.Location = new Point(505, 256);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(83, 74);
            btnPesquisa.TabIndex = 7;
            btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.BackColor = Color.Navy;
            btnBuscarProduto.FlatAppearance.BorderColor = Color.White;
            btnBuscarProduto.FlatAppearance.BorderSize = 0;
            btnBuscarProduto.FlatAppearance.MouseDownBackColor = Color.White;
            btnBuscarProduto.FlatAppearance.MouseOverBackColor = Color.Red;
            btnBuscarProduto.Image = Properties.Resources.image_transparente_50x50__1_;
            btnBuscarProduto.Location = new Point(382, 198);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.Size = new Size(98, 69);
            btnBuscarProduto.TabIndex = 8;
            btnBuscarProduto.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Gray;
            btnLimpar.FlatAppearance.BorderColor = Color.White;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatAppearance.MouseDownBackColor = Color.White;
            btnLimpar.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLimpar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(681, 663);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // Form5Gerenciamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(871, 753);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscarProduto);
            Controls.Add(btnPesquisa);
            Controls.Add(dataGridEstoque);
            Controls.Add(label5);
            Controls.Add(comboBoxFiltrar);
            Controls.Add(label4);
            Controls.Add(textBuscarProduto);
            Controls.Add(label3);
            Controls.Add(panel1Cabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5Gerenciamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5Organizar";
            panel1Cabecalho.ResumeLayout(false);
            panel1Cabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1Cabecalho;
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBuscarProduto;
        private Label label4;
        private ComboBox comboBoxFiltrar;
        private Label label5;
        private PictureBox pictureBox1;
        private DataGridView dataGridEstoque;
        private DataGridViewTextBoxColumn tblProduto;
        private DataGridViewTextBoxColumn tblCategoria;
        private DataGridViewTextBoxColumn tblQuantidade;
        private DataGridViewTextBoxColumn tblPreco;
        private DataGridViewTextBoxColumn tblSituacao;
        private Button btnPesquisa;
        private Button btnBuscarProduto;
        private Button btnLimpar;
    }
}