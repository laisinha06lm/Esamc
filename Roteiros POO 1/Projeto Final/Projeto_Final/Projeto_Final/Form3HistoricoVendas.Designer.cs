namespace Projeto_Final
{
    partial class Form3HistoricoVendas
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            gbFiltros = new GroupBox();
            panel3 = new Panel();
            btnLimparFiltros = new Button();
            btnPesquisar = new Button();
            dtpDataFinal = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            lblDataFinal = new Label();
            lblDataInicial = new Label();
            txtIdVenda = new TextBox();
            lblIdVenda = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lblTotalVendido = new Label();
            lblVendasEncontradas = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvHistoricoVendas = new DataGridView();
            colIdVenda = new DataGridViewTextBoxColumn();
            colDataHora = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            colPercentualDesconto = new DataGridViewTextBoxColumn();
            colValorDesconto = new DataGridViewTextBoxColumn();
            colValorTotal = new DataGridViewTextBoxColumn();
            colFormaPagamento = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            label7 = new Label();
            lblDetalhesVenda = new Label();
            dgvItensHistorico = new DataGridView();
            colCodigoProduto = new DataGridViewTextBoxColumn();
            colNomeProduto = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colPrecoUnitario = new DataGridViewTextBoxColumn();
            colSubtotalItem = new DataGridViewTextBoxColumn();
            lblOrientacao = new Label();
            panel1Cabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbFiltros.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensHistorico).BeginInit();
            SuspendLayout();
            // 
            // panel1Cabecalho
            // 
            panel1Cabecalho.BackColor = Color.FromArgb(0, 0, 192);
            panel1Cabecalho.Controls.Add(button1);
            panel1Cabecalho.Controls.Add(pictureBox1);
            panel1Cabecalho.Controls.Add(label2);
            panel1Cabecalho.Controls.Add(label1);
            panel1Cabecalho.Dock = DockStyle.Top;
            panel1Cabecalho.Location = new Point(0, 0);
            panel1Cabecalho.Name = "panel1Cabecalho";
            panel1Cabecalho.Size = new Size(1121, 121);
            panel1Cabecalho.TabIndex = 0;
            panel1Cabecalho.MouseMove += panel1Cabecalho_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Navy;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.Image = Properties.Resources.gato_x_50x50;
            button1.Location = new Point(983, 23);
            button1.Name = "button1";
            button1.Size = new Size(112, 59);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shop_transparente_100x100;
            pictureBox1.Location = new Point(847, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 75);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(218, 28);
            label2.TabIndex = 1;
            label2.Text = "HISTÓRICO DE VENDAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 67);
            label1.TabIndex = 0;
            label1.Text = "SuperMarket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 2);
            label3.Name = "label3";
            label3.Size = new Size(308, 32);
            label3.TabIndex = 1;
            label3.Text = "Consultar vendas realizadas";
            // 
            // gbFiltros
            // 
            gbFiltros.BackColor = Color.FromArgb(224, 224, 224);
            gbFiltros.Controls.Add(panel3);
            gbFiltros.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFiltros.Location = new Point(0, 217);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(1121, 255);
            gbFiltros.TabIndex = 2;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros de pesquisa";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnLimparFiltros);
            panel3.Controls.Add(btnPesquisar);
            panel3.Controls.Add(dtpDataFinal);
            panel3.Controls.Add(dtpDataInicial);
            panel3.Controls.Add(lblDataFinal);
            panel3.Controls.Add(lblDataInicial);
            panel3.Controls.Add(txtIdVenda);
            panel3.Controls.Add(lblIdVenda);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(15, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 192);
            panel3.TabIndex = 0;
            // 
            // btnLimparFiltros
            // 
            btnLimparFiltros.BackColor = Color.LightSlateGray;
            btnLimparFiltros.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimparFiltros.Location = new Point(642, 122);
            btnLimparFiltros.Name = "btnLimparFiltros";
            btnLimparFiltros.Size = new Size(213, 53);
            btnLimparFiltros.TabIndex = 8;
            btnLimparFiltros.Text = "Limpar filtros";
            btnLimparFiltros.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.DarkViolet;
            btnPesquisar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(222, 122);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(217, 53);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Checked = false;
            dtpDataFinal.CustomFormat = "dd/MM/yyyy";
            dtpDataFinal.Format = DateTimePickerFormat.Custom;
            dtpDataFinal.Location = new Point(883, 42);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.ShowCheckBox = true;
            dtpDataFinal.Size = new Size(162, 34);
            dtpDataFinal.TabIndex = 6;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Checked = false;
            dtpDataInicial.CustomFormat = "dd/MM/yyyy";
            dtpDataInicial.Format = DateTimePickerFormat.Custom;
            dtpDataInicial.Location = new Point(535, 39);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.ShowCheckBox = true;
            dtpDataInicial.Size = new Size(168, 34);
            dtpDataInicial.TabIndex = 5;
            // 
            // lblDataFinal
            // 
            lblDataFinal.AutoSize = true;
            lblDataFinal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataFinal.Location = new Point(736, 42);
            lblDataFinal.Name = "lblDataFinal";
            lblDataFinal.Size = new Size(99, 28);
            lblDataFinal.TabIndex = 4;
            lblDataFinal.Text = "Data final:";
            // 
            // lblDataInicial
            // 
            lblDataInicial.AutoSize = true;
            lblDataInicial.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataInicial.Location = new Point(397, 39);
            lblDataInicial.Name = "lblDataInicial";
            lblDataInicial.Size = new Size(112, 28);
            lblDataInicial.TabIndex = 3;
            lblDataInicial.Text = "Data inicial:";
            // 
            // txtIdVenda
            // 
            txtIdVenda.Location = new Point(209, 39);
            txtIdVenda.MaxLength = 20;
            txtIdVenda.Name = "txtIdVenda";
            txtIdVenda.Size = new Size(150, 34);
            txtIdVenda.TabIndex = 2;
            // 
            // lblIdVenda
            // 
            lblIdVenda.AutoSize = true;
            lblIdVenda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdVenda.Location = new Point(14, 39);
            lblIdVenda.Name = "lblIdVenda";
            lblIdVenda.Size = new Size(173, 28);
            lblIdVenda.TabIndex = 1;
            lblIdVenda.Text = "Número da venda:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 6);
            label6.Name = "label6";
            label6.Size = new Size(236, 21);
            label6.TabIndex = 0;
            label6.Text = "Pesquisar pelo número da venda";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblTotalVendido);
            panel2.Controls.Add(lblVendasEncontradas);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(1121, 94);
            panel2.TabIndex = 3;
            // 
            // lblTotalVendido
            // 
            lblTotalVendido.AutoSize = true;
            lblTotalVendido.Location = new Point(847, 46);
            lblTotalVendido.Name = "lblTotalVendido";
            lblTotalVendido.Size = new Size(72, 25);
            lblTotalVendido.TabIndex = 5;
            lblTotalVendido.Text = "R$ 0,00";
            lblTotalVendido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVendasEncontradas
            // 
            lblVendasEncontradas.AutoSize = true;
            lblVendasEncontradas.Location = new Point(303, 46);
            lblVendasEncontradas.Name = "lblVendasEncontradas";
            lblVendasEncontradas.Size = new Size(22, 25);
            lblVendasEncontradas.TabIndex = 4;
            lblVendasEncontradas.Text = "0";
            lblVendasEncontradas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(638, 43);
            label5.Name = "label5";
            label5.Size = new Size(180, 28);
            label5.TabIndex = 3;
            label5.Text = "Valor total vendido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 43);
            label4.Name = "label4";
            label4.Size = new Size(186, 28);
            label4.TabIndex = 2;
            label4.Text = "Vendas encontradas";
            // 
            // dgvHistoricoVendas
            // 
            dgvHistoricoVendas.AllowUserToAddRows = false;
            dgvHistoricoVendas.AllowUserToDeleteRows = false;
            dgvHistoricoVendas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistoricoVendas.BackgroundColor = Color.White;
            dgvHistoricoVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistoricoVendas.Columns.AddRange(new DataGridViewColumn[] { colIdVenda, colDataHora, colSubtotal, colPercentualDesconto, colValorDesconto, colValorTotal, colFormaPagamento, colStatus });
            dgvHistoricoVendas.Location = new Point(0, 514);
            dgvHistoricoVendas.MultiSelect = false;
            dgvHistoricoVendas.Name = "dgvHistoricoVendas";
            dgvHistoricoVendas.ReadOnly = true;
            dgvHistoricoVendas.RowHeadersVisible = false;
            dgvHistoricoVendas.RowHeadersWidth = 62;
            dgvHistoricoVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistoricoVendas.Size = new Size(1109, 210);
            dgvHistoricoVendas.TabIndex = 4;
            // 
            // colIdVenda
            // 
            colIdVenda.HeaderText = "Nº Venda";
            colIdVenda.MinimumWidth = 8;
            colIdVenda.Name = "colIdVenda";
            colIdVenda.ReadOnly = true;
            // 
            // colDataHora
            // 
            colDataHora.HeaderText = "Data e Hora";
            colDataHora.MinimumWidth = 8;
            colDataHora.Name = "colDataHora";
            colDataHora.ReadOnly = true;
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.MinimumWidth = 8;
            colSubtotal.Name = "colSubtotal";
            colSubtotal.ReadOnly = true;
            // 
            // colPercentualDesconto
            // 
            colPercentualDesconto.HeaderText = "Desconto (%)";
            colPercentualDesconto.MinimumWidth = 8;
            colPercentualDesconto.Name = "colPercentualDesconto";
            colPercentualDesconto.ReadOnly = true;
            // 
            // colValorDesconto
            // 
            colValorDesconto.HeaderText = "Valor Desconto";
            colValorDesconto.MinimumWidth = 8;
            colValorDesconto.Name = "colValorDesconto";
            colValorDesconto.ReadOnly = true;
            // 
            // colValorTotal
            // 
            colValorTotal.HeaderText = "Total";
            colValorTotal.MinimumWidth = 8;
            colValorTotal.Name = "colValorTotal";
            colValorTotal.ReadOnly = true;
            // 
            // colFormaPagamento
            // 
            colFormaPagamento.HeaderText = "Pagamento";
            colFormaPagamento.MinimumWidth = 8;
            colFormaPagamento.Name = "colFormaPagamento";
            colFormaPagamento.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 482);
            label7.Name = "label7";
            label7.Size = new Size(201, 32);
            label7.TabIndex = 5;
            label7.Text = "Vendas realizadas";
            // 
            // lblDetalhesVenda
            // 
            lblDetalhesVenda.AutoSize = true;
            lblDetalhesVenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetalhesVenda.ForeColor = Color.Black;
            lblDetalhesVenda.Location = new Point(15, 734);
            lblDetalhesVenda.Name = "lblDetalhesVenda";
            lblDetalhesVenda.Size = new Size(346, 32);
            lblDetalhesVenda.TabIndex = 6;
            lblDetalhesVenda.Text = "Produtos da venda selecionada";
            // 
            // dgvItensHistorico
            // 
            dgvItensHistorico.AllowUserToAddRows = false;
            dgvItensHistorico.AllowUserToDeleteRows = false;
            dgvItensHistorico.BackgroundColor = Color.White;
            dgvItensHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensHistorico.Columns.AddRange(new DataGridViewColumn[] { colCodigoProduto, colNomeProduto, colQuantidade, colPrecoUnitario, colSubtotalItem });
            dgvItensHistorico.Location = new Point(208, 772);
            dgvItensHistorico.MultiSelect = false;
            dgvItensHistorico.Name = "dgvItensHistorico";
            dgvItensHistorico.ReadOnly = true;
            dgvItensHistorico.RowHeadersVisible = false;
            dgvItensHistorico.RowHeadersWidth = 62;
            dgvItensHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensHistorico.Size = new Size(754, 225);
            dgvItensHistorico.TabIndex = 7;
            // 
            // colCodigoProduto
            // 
            colCodigoProduto.HeaderText = "Código";
            colCodigoProduto.MinimumWidth = 8;
            colCodigoProduto.Name = "colCodigoProduto";
            colCodigoProduto.ReadOnly = true;
            colCodigoProduto.Width = 150;
            // 
            // colNomeProduto
            // 
            colNomeProduto.HeaderText = "Produto";
            colNomeProduto.MinimumWidth = 8;
            colNomeProduto.Name = "colNomeProduto";
            colNomeProduto.ReadOnly = true;
            colNomeProduto.Width = 150;
            // 
            // colQuantidade
            // 
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.MinimumWidth = 8;
            colQuantidade.Name = "colQuantidade";
            colQuantidade.ReadOnly = true;
            colQuantidade.Width = 150;
            // 
            // colPrecoUnitario
            // 
            colPrecoUnitario.HeaderText = "Valor Unitário";
            colPrecoUnitario.MinimumWidth = 8;
            colPrecoUnitario.Name = "colPrecoUnitario";
            colPrecoUnitario.ReadOnly = true;
            colPrecoUnitario.Width = 150;
            // 
            // colSubtotalItem
            // 
            colSubtotalItem.HeaderText = "Subtotal";
            colSubtotalItem.MinimumWidth = 8;
            colSubtotalItem.Name = "colSubtotalItem";
            colSubtotalItem.ReadOnly = true;
            colSubtotalItem.Width = 150;
            // 
            // lblOrientacao
            // 
            lblOrientacao.AutoSize = true;
            lblOrientacao.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrientacao.ForeColor = Color.Gray;
            lblOrientacao.Location = new Point(349, 1009);
            lblOrientacao.Name = "lblOrientacao";
            lblOrientacao.Size = new Size(452, 21);
            lblOrientacao.TabIndex = 8;
            lblOrientacao.Text = "Selecione uma venda acima para visualizar seus produtos.";
            // 
            // Form3HistoricoVendas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1121, 1035);
            Controls.Add(lblOrientacao);
            Controls.Add(dgvItensHistorico);
            Controls.Add(lblDetalhesVenda);
            Controls.Add(label7);
            Controls.Add(dgvHistoricoVendas);
            Controls.Add(panel2);
            Controls.Add(gbFiltros);
            Controls.Add(panel1Cabecalho);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3HistoricoVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1Cabecalho.ResumeLayout(false);
            panel1Cabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbFiltros.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistoricoVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1Cabecalho;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private GroupBox gbFiltros;
        private Panel panel2;
        private Panel panel3;
        private Label lblTotalVendido;
        private Label lblVendasEncontradas;
        private Label label5;
        private Label label4;
        private TextBox txtIdVenda;
        private Label lblIdVenda;
        private Label label6;
        private Button btnLimparFiltros;
        private Button btnPesquisar;
        private DateTimePicker dtpDataFinal;
        private DateTimePicker dtpDataInicial;
        private Label lblDataFinal;
        private Label lblDataInicial;
        private DataGridView dgvHistoricoVendas;
        private DataGridViewTextBoxColumn colIdVenda;
        private DataGridViewTextBoxColumn colDataHora;
        private DataGridViewTextBoxColumn colSubtotal;
        private DataGridViewTextBoxColumn colPercentualDesconto;
        private DataGridViewTextBoxColumn colValorDesconto;
        private DataGridViewTextBoxColumn colValorTotal;
        private DataGridViewTextBoxColumn colFormaPagamento;
        private DataGridViewTextBoxColumn colStatus;
        private Label label7;
        private Label lblDetalhesVenda;
        private DataGridView dgvItensHistorico;
        private DataGridViewTextBoxColumn colCodigoProduto;
        private DataGridViewTextBoxColumn colNomeProduto;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colPrecoUnitario;
        private DataGridViewTextBoxColumn colSubtotalItem;
        private Label lblOrientacao;
        private Button button1;
    }
}