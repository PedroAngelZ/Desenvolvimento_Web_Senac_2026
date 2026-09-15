namespace Calculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLimpar = new Button();
            btnLimparEntrada = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSoma = new Button();
            btnInverterSinal = new Button();
            btn0 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtracao = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicacao = new Button();
            btnInverso = new Button();
            btnQuadrado = new Button();
            btnRaizQuadrada = new Button();
            btnDivisao = new Button();
            btnPorcento = new Button();
            btnBackspace = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnMemoryClear = new Button();
            btnMemoryRecall = new Button();
            btnMemoryAdd = new Button();
            btnMemorySubtract = new Button();
            btnMemoryStore = new Button();
            btnMemoryList = new Button();
            txtDisplay = new TextBox();
            lblHistorico = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnLimpar, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLimparEntrada, 1, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 4);
            tableLayoutPanel1.Controls.Add(btn2, 1, 4);
            tableLayoutPanel1.Controls.Add(btn3, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSoma, 3, 4);
            tableLayoutPanel1.Controls.Add(btnInverterSinal, 0, 5);
            tableLayoutPanel1.Controls.Add(btn0, 1, 5);
            tableLayoutPanel1.Controls.Add(btn4, 0, 3);
            tableLayoutPanel1.Controls.Add(btn5, 1, 3);
            tableLayoutPanel1.Controls.Add(btn6, 2, 3);
            tableLayoutPanel1.Controls.Add(btnSubtracao, 3, 3);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btnMultiplicacao, 3, 2);
            tableLayoutPanel1.Controls.Add(btnInverso, 0, 1);
            tableLayoutPanel1.Controls.Add(btnQuadrado, 1, 1);
            tableLayoutPanel1.Controls.Add(btnRaizQuadrada, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDivisao, 3, 1);
            tableLayoutPanel1.Controls.Add(btnPorcento, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBackspace, 3, 0);
            tableLayoutPanel1.Controls.Add(btnVirgula, 2, 5);
            tableLayoutPanel1.Controls.Add(btnIgual, 3, 5);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            tableLayoutPanel1.ForeColor = SystemColors.ControlDarkDark;
            tableLayoutPanel1.Location = new Point(0, 178);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(301, 312);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.GradientActiveCaption;
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btnLimpar.Location = new Point(153, 3);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(69, 46);
            btnLimpar.TabIndex = 25;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += BotaoLimparTudo_Click;
            // 
            // btnLimparEntrada
            // 
            btnLimparEntrada.BackColor = SystemColors.GradientActiveCaption;
            btnLimparEntrada.Dock = DockStyle.Fill;
            btnLimparEntrada.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btnLimparEntrada.Location = new Point(78, 3);
            btnLimparEntrada.Name = "btnLimparEntrada";
            btnLimparEntrada.Size = new Size(69, 46);
            btnLimparEntrada.TabIndex = 24;
            btnLimparEntrada.Text = "CE";
            btnLimparEntrada.UseVisualStyleBackColor = false;
            btnLimparEntrada.Click += BotaoLimparEntrada_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.GradientActiveCaption;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn1.Location = new Point(3, 211);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 46);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BotaoNumero_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.GradientActiveCaption;
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn2.Location = new Point(78, 211);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 46);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BotaoNumero_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.GradientActiveCaption;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn3.Location = new Point(153, 211);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 46);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BotaoNumero_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = SystemColors.GradientActiveCaption;
            btnSoma.Dock = DockStyle.Fill;
            btnSoma.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(228, 211);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(70, 46);
            btnSoma.TabIndex = 3;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += BotaoOperacao_Click;
            // 
            // btnInverterSinal
            // 
            btnInverterSinal.BackColor = SystemColors.GradientActiveCaption;
            btnInverterSinal.Dock = DockStyle.Fill;
            btnInverterSinal.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInverterSinal.Location = new Point(3, 263);
            btnInverterSinal.Name = "btnInverterSinal";
            btnInverterSinal.Size = new Size(69, 46);
            btnInverterSinal.TabIndex = 4;
            btnInverterSinal.Text = "±";
            btnInverterSinal.UseVisualStyleBackColor = false;
            btnInverterSinal.Click += BotaoInverterSinal_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.GradientActiveCaption;
            btn0.Dock = DockStyle.Fill;
            btn0.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn0.Location = new Point(78, 263);
            btn0.Name = "btn0";
            btn0.Size = new Size(69, 46);
            btn0.TabIndex = 5;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BotaoNumero_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.GradientActiveCaption;
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn4.Location = new Point(3, 159);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 46);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BotaoNumero_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.GradientActiveCaption;
            btn5.Dock = DockStyle.Fill;
            btn5.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn5.Location = new Point(78, 159);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 46);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BotaoNumero_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.GradientActiveCaption;
            btn6.Dock = DockStyle.Fill;
            btn6.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn6.Location = new Point(153, 159);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 46);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BotaoNumero_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = SystemColors.GradientActiveCaption;
            btnSubtracao.Dock = DockStyle.Fill;
            btnSubtracao.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtracao.Location = new Point(228, 159);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(70, 46);
            btnSubtracao.TabIndex = 9;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += BotaoOperacao_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.GradientActiveCaption;
            btn7.Dock = DockStyle.Fill;
            btn7.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn7.Location = new Point(3, 107);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 46);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BotaoNumero_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.GradientActiveCaption;
            btn8.Dock = DockStyle.Fill;
            btn8.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn8.Location = new Point(78, 107);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 46);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BotaoNumero_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.GradientActiveCaption;
            btn9.Dock = DockStyle.Fill;
            btn9.Font = new Font("Microsoft Tai Le", 9.75F, FontStyle.Bold);
            btn9.Location = new Point(153, 107);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 46);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BotaoNumero_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = SystemColors.GradientActiveCaption;
            btnMultiplicacao.Dock = DockStyle.Fill;
            btnMultiplicacao.Font = new Font("Microsoft Tai Le", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicacao.Location = new Point(228, 107);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(70, 46);
            btnMultiplicacao.TabIndex = 13;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += BotaoOperacao_Click;
            // 
            // btnInverso
            // 
            btnInverso.BackColor = SystemColors.GradientActiveCaption;
            btnInverso.Dock = DockStyle.Fill;
            btnInverso.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInverso.Location = new Point(3, 55);
            btnInverso.Name = "btnInverso";
            btnInverso.Size = new Size(69, 46);
            btnInverso.TabIndex = 14;
            btnInverso.Text = "¹⁄𝑥";
            btnInverso.UseVisualStyleBackColor = false;
            btnInverso.Click += BotaoInverso_Click;
            // 
            // btnQuadrado
            // 
            btnQuadrado.BackColor = SystemColors.GradientActiveCaption;
            btnQuadrado.Dock = DockStyle.Fill;
            btnQuadrado.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuadrado.Location = new Point(78, 55);
            btnQuadrado.Name = "btnQuadrado";
            btnQuadrado.Size = new Size(69, 46);
            btnQuadrado.TabIndex = 15;
            btnQuadrado.Text = "x²";
            btnQuadrado.UseVisualStyleBackColor = false;
            btnQuadrado.Click += BotaoQuadrado_Click;
            // 
            // btnRaizQuadrada
            // 
            btnRaizQuadrada.BackColor = SystemColors.GradientActiveCaption;
            btnRaizQuadrada.Dock = DockStyle.Fill;
            btnRaizQuadrada.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRaizQuadrada.Location = new Point(153, 55);
            btnRaizQuadrada.Name = "btnRaizQuadrada";
            btnRaizQuadrada.Size = new Size(69, 46);
            btnRaizQuadrada.TabIndex = 16;
            btnRaizQuadrada.Text = "²√x";
            btnRaizQuadrada.UseVisualStyleBackColor = false;
            btnRaizQuadrada.Click += BotaoRaiz_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = SystemColors.GradientActiveCaption;
            btnDivisao.Dock = DockStyle.Fill;
            btnDivisao.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivisao.Location = new Point(228, 55);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(70, 46);
            btnDivisao.TabIndex = 17;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += BotaoOperacao_Click;
            // 
            // btnPorcento
            // 
            btnPorcento.BackColor = SystemColors.GradientActiveCaption;
            btnPorcento.Dock = DockStyle.Fill;
            btnPorcento.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPorcento.ForeColor = SystemColors.ControlDarkDark;
            btnPorcento.Location = new Point(3, 3);
            btnPorcento.Name = "btnPorcento";
            btnPorcento.Size = new Size(69, 46);
            btnPorcento.TabIndex = 18;
            btnPorcento.Text = "%";
            btnPorcento.UseVisualStyleBackColor = false;
            btnPorcento.Click += BotaoPorcentagem_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = SystemColors.GradientActiveCaption;
            btnBackspace.Dock = DockStyle.Fill;
            btnBackspace.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackspace.Location = new Point(228, 3);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(70, 46);
            btnBackspace.TabIndex = 21;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += BotaoBackSpace_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = SystemColors.GradientActiveCaption;
            btnVirgula.Dock = DockStyle.Fill;
            btnVirgula.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgula.Location = new Point(153, 263);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(69, 46);
            btnVirgula.TabIndex = 22;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += BotaoVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.AliceBlue;
            btnIgual.Dock = DockStyle.Fill;
            btnIgual.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(228, 263);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(70, 46);
            btnIgual.TabIndex = 23;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += BotaoIgual_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(btnMemoryClear, 0, 0);
            tableLayoutPanel2.Controls.Add(btnMemoryRecall, 1, 0);
            tableLayoutPanel2.Controls.Add(btnMemoryAdd, 2, 0);
            tableLayoutPanel2.Controls.Add(btnMemorySubtract, 3, 0);
            tableLayoutPanel2.Controls.Add(btnMemoryStore, 4, 0);
            tableLayoutPanel2.Controls.Add(btnMemoryList, 5, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
            tableLayoutPanel2.ForeColor = SystemColors.ControlDarkDark;
            tableLayoutPanel2.Location = new Point(0, 146);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(301, 32);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.BackColor = SystemColors.GradientActiveCaption;
            btnMemoryClear.Dock = DockStyle.Fill;
            btnMemoryClear.ForeColor = SystemColors.InactiveCaptionText;
            btnMemoryClear.Location = new Point(3, 3);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(44, 26);
            btnMemoryClear.TabIndex = 0;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = false;
            btnMemoryClear.Click += BotaoMC_Click;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.BackColor = SystemColors.GradientActiveCaption;
            btnMemoryRecall.Dock = DockStyle.Fill;
            btnMemoryRecall.ForeColor = SystemColors.ActiveCaptionText;
            btnMemoryRecall.Location = new Point(53, 3);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(44, 26);
            btnMemoryRecall.TabIndex = 1;
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = false;
            btnMemoryRecall.Click += BotaoMR_Click;
            // 
            // btnMemoryAdd
            // 
            btnMemoryAdd.BackColor = SystemColors.GradientActiveCaption;
            btnMemoryAdd.Dock = DockStyle.Fill;
            btnMemoryAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnMemoryAdd.Location = new Point(103, 3);
            btnMemoryAdd.Name = "btnMemoryAdd";
            btnMemoryAdd.Size = new Size(44, 26);
            btnMemoryAdd.TabIndex = 2;
            btnMemoryAdd.Text = "M+";
            btnMemoryAdd.UseVisualStyleBackColor = false;
            btnMemoryAdd.Click += BotaoMmais_Click;
            // 
            // btnMemorySubtract
            // 
            btnMemorySubtract.BackColor = SystemColors.GradientActiveCaption;
            btnMemorySubtract.Dock = DockStyle.Fill;
            btnMemorySubtract.ForeColor = SystemColors.ActiveCaptionText;
            btnMemorySubtract.Location = new Point(153, 3);
            btnMemorySubtract.Name = "btnMemorySubtract";
            btnMemorySubtract.Size = new Size(44, 26);
            btnMemorySubtract.TabIndex = 3;
            btnMemorySubtract.Text = "M-";
            btnMemorySubtract.UseVisualStyleBackColor = false;
            btnMemorySubtract.Click += BotaoMmenos_Click;
            // 
            // btnMemoryStore
            // 
            btnMemoryStore.BackColor = SystemColors.GradientActiveCaption;
            btnMemoryStore.Dock = DockStyle.Fill;
            btnMemoryStore.ForeColor = SystemColors.ActiveCaptionText;
            btnMemoryStore.Location = new Point(203, 3);
            btnMemoryStore.Name = "btnMemoryStore";
            btnMemoryStore.Size = new Size(44, 26);
            btnMemoryStore.TabIndex = 4;
            btnMemoryStore.Text = "MS";
            btnMemoryStore.UseVisualStyleBackColor = false;
            btnMemoryStore.Click += BotaoMS_Click;
            // 
            // btnMemoryList
            // 
            btnMemoryList.BackColor = SystemColors.GradientActiveCaption;
            btnMemoryList.Dock = DockStyle.Fill;
            btnMemoryList.Enabled = false;
            btnMemoryList.ForeColor = SystemColors.ActiveCaptionText;
            btnMemoryList.Location = new Point(253, 3);
            btnMemoryList.Name = "btnMemoryList";
            btnMemoryList.Size = new Size(45, 26);
            btnMemoryList.TabIndex = 5;
            btnMemoryList.Text = "M˅";
            btnMemoryList.UseVisualStyleBackColor = false;
            btnMemoryList.Click += BotaoMv_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.GradientInactiveCaption;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.ControlDarkDark;
            txtDisplay.Location = new Point(4, 77);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(294, 66);
            txtDisplay.TabIndex = 2;
            txtDisplay.TabStop = false;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHistorico
            // 
            lblHistorico.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorico.ForeColor = Color.LightSlateGray;
            lblHistorico.Location = new Point(0, 47);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(301, 27);
            lblHistorico.TabIndex = 3;
            lblHistorico.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(301, 490);
            Controls.Add(lblHistorico);
            Controls.Add(txtDisplay);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSoma;
        private Button btnInverterSinal;
        private Button btn0;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtracao;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicacao;
        private Button btnInverso;
        private Button btnQuadrado;
        private Button btnRaizQuadrada;
        private Button btnDivisao;
        private Button btnPorcento;
        private Button btnBackspace;
        private Button btnVirgula;
        private Button btnIgual;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnMemoryClear;
        private Button btnMemoryRecall;
        private Button btnMemoryAdd;
        private Button btnMemorySubtract;
        private Button btnMemoryStore;
        private Button btnMemoryList;
        private TextBox txtDisplay;
        private Label lblHistorico;
        private Button btnLimpar;
        private Button btnLimparEntrada;
    }
}
