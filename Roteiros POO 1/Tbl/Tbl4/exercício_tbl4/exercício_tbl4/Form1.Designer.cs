namespace exercício_tbl4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            bntRestaurar = new Button();
            bntMaximizar = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            btnSugestoes = new Button();
            btnVendas = new Button();
            btnProdutos = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(bntRestaurar);
            panel1.Controls.Add(bntMaximizar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 150);
            panel1.TabIndex = 0;
            panel1.MouseMove += panel1_MouseDown;
            // 
            // bntRestaurar
            // 
            bntRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntRestaurar.FlatAppearance.BorderColor = Color.White;
            bntRestaurar.FlatAppearance.BorderSize = 0;
            bntRestaurar.FlatAppearance.MouseDownBackColor = Color.White;
            bntRestaurar.FlatAppearance.MouseOverBackColor = Color.Red;
            bntRestaurar.FlatStyle = FlatStyle.Flat;
            bntRestaurar.Image = (Image)resources.GetObject("bntRestaurar.Image");
            bntRestaurar.Location = new Point(721, 15);
            bntRestaurar.Name = "bntRestaurar";
            bntRestaurar.Size = new Size(41, 52);
            bntRestaurar.TabIndex = 3;
            bntRestaurar.UseVisualStyleBackColor = true;
            bntRestaurar.Click += bntRestaurar_Click;
            // 
            // bntMaximizar
            // 
            bntMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntMaximizar.FlatAppearance.BorderColor = Color.White;
            bntMaximizar.FlatAppearance.BorderSize = 0;
            bntMaximizar.FlatAppearance.MouseDownBackColor = Color.White;
            bntMaximizar.FlatAppearance.MouseOverBackColor = Color.Red;
            bntMaximizar.FlatStyle = FlatStyle.Flat;
            bntMaximizar.ForeColor = Color.White;
            bntMaximizar.Image = Properties.Resources.maximizar_janelas_rosa_40x40_transparente;
            bntMaximizar.Location = new Point(768, 14);
            bntMaximizar.Name = "bntMaximizar";
            bntMaximizar.Size = new Size(59, 57);
            bntMaximizar.TabIndex = 2;
            bntMaximizar.UseVisualStyleBackColor = true;
            bntMaximizar.Click += bntMaximizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(297, 67);
            label1.TabIndex = 1;
            label1.Text = "Meu Sistema";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.botao_fechar_rosa_40x40_transparente;
            button1.Location = new Point(842, 12);
            button1.Name = "button1";
            button1.Size = new Size(46, 59);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(255, 128, 255);
            panel2.Controls.Add(btnSugestoes);
            panel2.Controls.Add(btnVendas);
            panel2.Controls.Add(btnProdutos);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 403);
            panel2.TabIndex = 1;
            // 
            // btnSugestoes
            // 
            btnSugestoes.FlatAppearance.BorderColor = Color.White;
            btnSugestoes.FlatAppearance.BorderSize = 0;
            btnSugestoes.FlatAppearance.MouseDownBackColor = Color.White;
            btnSugestoes.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSugestoes.FlatStyle = FlatStyle.Flat;
            btnSugestoes.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSugestoes.ForeColor = Color.White;
            btnSugestoes.Image = Properties.Resources.icone_balao_50x50;
            btnSugestoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSugestoes.Location = new Point(3, 232);
            btnSugestoes.Name = "btnSugestoes";
            btnSugestoes.Size = new Size(259, 59);
            btnSugestoes.TabIndex = 3;
            btnSugestoes.Text = "Sugestões";
            btnSugestoes.UseVisualStyleBackColor = true;
            btnSugestoes.Click += btnSugestoes_Click;
            // 
            // btnVendas
            // 
            btnVendas.FlatAppearance.BorderColor = Color.White;
            btnVendas.FlatAppearance.BorderSize = 0;
            btnVendas.FlatAppearance.MouseDownBackColor = Color.White;
            btnVendas.FlatAppearance.MouseOverBackColor = Color.Red;
            btnVendas.FlatStyle = FlatStyle.Flat;
            btnVendas.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendas.ForeColor = Color.White;
            btnVendas.Image = Properties.Resources.to_do_list_50x50;
            btnVendas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendas.Location = new Point(12, 168);
            btnVendas.Name = "btnVendas";
            btnVendas.Size = new Size(235, 58);
            btnVendas.TabIndex = 2;
            btnVendas.Text = "Vendas";
            btnVendas.UseVisualStyleBackColor = true;
            btnVendas.Click += btnVendas_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.FlatAppearance.BorderColor = Color.White;
            btnProdutos.FlatAppearance.BorderSize = 0;
            btnProdutos.FlatAppearance.MouseDownBackColor = Color.White;
            btnProdutos.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProdutos.FlatStyle = FlatStyle.Flat;
            btnProdutos.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProdutos.ForeColor = Color.White;
            btnProdutos.Image = Properties.Resources.loto_50x50;
            btnProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProdutos.Location = new Point(12, 90);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(250, 63);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Script", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.clientes_sem_texto_40x40_transparente;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 7);
            button2.Name = "button2";
            button2.Size = new Size(246, 67);
            button2.TabIndex = 0;
            button2.Text = "Clientes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(900, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button bntMaximizar;
        private Button bntRestaurar;
        private Button btnProdutos;
        private Button btnSugestoes;
        private Button btnVendas;
    }
}
