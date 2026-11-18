namespace Projeto_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1Cabecalho = new Panel();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label3Linha = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2Caixa = new Panel();
            pictureBox2 = new PictureBox();
            label9 = new Label();
            label5 = new Label();
            panel3Produtos = new Panel();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            label6 = new Label();
            panel4Estoque = new Panel();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            label7 = new Label();
            panel5HistoricoVendas = new Panel();
            pictureBox5 = new PictureBox();
            label12 = new Label();
            label8 = new Label();
            panel1Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2Caixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3Produtos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5HistoricoVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1Cabecalho
            // 
            panel1Cabecalho.BackColor = Color.Navy;
            panel1Cabecalho.Controls.Add(button1);
            panel1Cabecalho.Controls.Add(label4);
            panel1Cabecalho.Controls.Add(label3);
            panel1Cabecalho.Controls.Add(label3Linha);
            panel1Cabecalho.Controls.Add(pictureBox1);
            panel1Cabecalho.Controls.Add(label2);
            panel1Cabecalho.Controls.Add(label1);
            panel1Cabecalho.Dock = DockStyle.Top;
            panel1Cabecalho.Location = new Point(0, 0);
            panel1Cabecalho.Name = "panel1Cabecalho";
            panel1Cabecalho.Size = new Size(878, 205);
            panel1Cabecalho.TabIndex = 0;
            panel1Cabecalho.MouseMove += panel1Cabecalho_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Image = Properties.Resources.gato_x_50x50;
            button1.Location = new Point(763, 4);
            button1.Name = "button1";
            button1.Size = new Size(112, 62);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 157);
            label4.Name = "label4";
            label4.Size = new Size(169, 21);
            label4.TabIndex = 7;
            label4.Text = "Bem-vindo ao sistema!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(314, 53);
            label3.TabIndex = 6;
            label3.Text = "Painel principal";
            // 
            // label3Linha
            // 
            label3Linha.BackColor = Color.Navy;
            label3Linha.BorderStyle = BorderStyle.Fixed3D;
            label3Linha.Location = new Point(0, 94);
            label3Linha.Name = "label3Linha";
            label3Linha.Size = new Size(876, 10);
            label3Linha.TabIndex = 5;
            label3Linha.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Image = Properties.Resources.carrinho_frutas_50x50;
            pictureBox1.Location = new Point(681, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(319, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema de gerenciamento de supermercado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(453, 53);
            label1.TabIndex = 0;
            label1.Text = "SUPERMARKET SYSTEM";
            // 
            // panel2Caixa
            // 
            panel2Caixa.BackColor = Color.FromArgb(128, 255, 128);
            panel2Caixa.Controls.Add(pictureBox2);
            panel2Caixa.Controls.Add(label9);
            panel2Caixa.Controls.Add(label5);
            panel2Caixa.Location = new Point(0, 223);
            panel2Caixa.Name = "panel2Caixa";
            panel2Caixa.Size = new Size(424, 150);
            panel2Caixa.TabIndex = 1;
            panel2Caixa.Click += panel2Caixa_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cesta_50x50_transparente;
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 52);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(12, 104);
            label9.Name = "label9";
            label9.Size = new Size(265, 25);
            label9.TabIndex = 1;
            label9.Text = "Registrar vendas e pagamentos.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 47);
            label5.Name = "label5";
            label5.Size = new Size(97, 44);
            label5.TabIndex = 0;
            label5.Text = "Caixa";
            // 
            // panel3Produtos
            // 
            panel3Produtos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3Produtos.BackColor = Color.FromArgb(128, 128, 255);
            panel3Produtos.Controls.Add(pictureBox3);
            panel3Produtos.Controls.Add(label10);
            panel3Produtos.Controls.Add(label6);
            panel3Produtos.Location = new Point(449, 223);
            panel3Produtos.Name = "panel3Produtos";
            panel3Produtos.Size = new Size(426, 150);
            panel3Produtos.TabIndex = 2;
            panel3Produtos.Click += panel3Produtos_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.cesta_compras_50x50_transparente;
            pictureBox3.Location = new Point(22, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 52);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(22, 104);
            label10.Name = "label10";
            label10.Size = new Size(261, 25);
            label10.TabIndex = 1;
            label10.Text = "Cadastrar e gerenciar produtos.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 47);
            label6.Name = "label6";
            label6.Size = new Size(142, 44);
            label6.TabIndex = 0;
            label6.Text = "Produtos";
            // 
            // panel4Estoque
            // 
            panel4Estoque.BackColor = Color.Fuchsia;
            panel4Estoque.Controls.Add(pictureBox4);
            panel4Estoque.Controls.Add(label11);
            panel4Estoque.Controls.Add(label7);
            panel4Estoque.Location = new Point(0, 394);
            panel4Estoque.Name = "panel4Estoque";
            panel4Estoque.Size = new Size(424, 150);
            panel4Estoque.TabIndex = 3;
            panel4Estoque.Click += panel4Estoque_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.caixas_50x50_transparente;
            pictureBox4.Location = new Point(12, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 48);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 107);
            label11.Name = "label11";
            label11.Size = new Size(196, 25);
            label11.TabIndex = 1;
            label11.Text = "Organizar os produtos.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 52);
            label7.Name = "label7";
            label7.Size = new Size(129, 44);
            label7.TabIndex = 0;
            label7.Text = "Estoque";
            // 
            // panel5HistoricoVendas
            // 
            panel5HistoricoVendas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5HistoricoVendas.BackColor = Color.FromArgb(255, 255, 192);
            panel5HistoricoVendas.Controls.Add(pictureBox5);
            panel5HistoricoVendas.Controls.Add(label12);
            panel5HistoricoVendas.Controls.Add(label8);
            panel5HistoricoVendas.Location = new Point(452, 394);
            panel5HistoricoVendas.Name = "panel5HistoricoVendas";
            panel5HistoricoVendas.Size = new Size(426, 150);
            panel5HistoricoVendas.TabIndex = 4;
            panel5HistoricoVendas.Click += panel5HistoricoVendas_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.ampulheta_50x50_transparente;
            pictureBox5.Location = new Point(19, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 56);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 107);
            label12.Name = "label12";
            label12.Size = new Size(234, 25);
            label12.TabIndex = 1;
            label12.Text = "Consultar vendas realizadas.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Monotype Corsiva", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 52);
            label8.Name = "label8";
            label8.Size = new Size(287, 44);
            label8.TabIndex = 0;
            label8.Text = "Histórico de vendas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 544);
            Controls.Add(panel5HistoricoVendas);
            Controls.Add(panel4Estoque);
            Controls.Add(panel3Produtos);
            Controls.Add(panel2Caixa);
            Controls.Add(panel1Cabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1Cabecalho.ResumeLayout(false);
            panel1Cabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2Caixa.ResumeLayout(false);
            panel2Caixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3Produtos.ResumeLayout(false);
            panel3Produtos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4Estoque.ResumeLayout(false);
            panel4Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5HistoricoVendas.ResumeLayout(false);
            panel5HistoricoVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1Cabecalho;
        private Label label2;
        private Label label1;
        private Panel panel2Caixa;
        private PictureBox pictureBox1;
        private Panel panel3Produtos;
        private Panel panel4Estoque;
        private Panel panel5HistoricoVendas;
        private Label label3Linha;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button button1;
    }
}
