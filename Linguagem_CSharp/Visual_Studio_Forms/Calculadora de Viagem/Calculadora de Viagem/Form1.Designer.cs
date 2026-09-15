namespace Calculadora_de_Viagem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            calcular = new Button();
            limpar = new Button();
            txtPreco = new TextBox();
            txtConsumo = new TextBox();
            txtDitancia = new TextBox();
            Dados = new GroupBox();
            Resultado = new GroupBox();
            lblCustoResultado = new TextBox();
            label4 = new Label();
            lblLitrosResultado = new TextBox();
            LitrosNeces = new Label();
            Dados.SuspendLayout();
            Resultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 0;
            label1.Text = "Distancia a Percorrer (Km)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 143);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 3;
            label2.Text = "Consumo do Veiculo (Km/L)";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 245);
            label3.Name = "label3";
            label3.Size = new Size(205, 15);
            label3.TabIndex = 5;
            label3.Text = "Preço por Litro do Combustivel (R$)\r\n";
            label3.Click += label3_Click;
            // 
            // calcular
            // 
            calcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calcular.Location = new Point(12, 491);
            calcular.Name = "calcular";
            calcular.Size = new Size(124, 53);
            calcular.TabIndex = 7;
            calcular.Text = "Calcular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += btnCalcular_Click;
            // 
            // limpar
            // 
            limpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            limpar.Location = new Point(620, 491);
            limpar.Name = "limpar";
            limpar.Size = new Size(124, 53);
            limpar.TabIndex = 8;
            limpar.Text = "Limpar";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += bntLimpar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(6, 263);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(304, 23);
            txtPreco.TabIndex = 9;
            // 
            // txtConsumo
            // 
            txtConsumo.Location = new Point(6, 161);
            txtConsumo.Name = "txtConsumo";
            txtConsumo.Size = new Size(304, 23);
            txtConsumo.TabIndex = 10;
            // 
            // txtDitancia
            // 
            txtDitancia.Location = new Point(0, 57);
            txtDitancia.Name = "txtDitancia";
            txtDitancia.Size = new Size(304, 23);
            txtDitancia.TabIndex = 11;
            txtDitancia.TextChanged += btnCalcular_Click;
            // 
            // Dados
            // 
            Dados.Controls.Add(txtDitancia);
            Dados.Controls.Add(txtConsumo);
            Dados.Controls.Add(txtPreco);
            Dados.Controls.Add(label3);
            Dados.Controls.Add(label2);
            Dados.Controls.Add(label1);
            Dados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dados.Location = new Point(12, 36);
            Dados.Name = "Dados";
            Dados.Size = new Size(329, 303);
            Dados.TabIndex = 12;
            Dados.TabStop = false;
            Dados.Text = "Dados da Viagem";
            // 
            // Resultado
            // 
            Resultado.Controls.Add(lblCustoResultado);
            Resultado.Controls.Add(label4);
            Resultado.Controls.Add(lblLitrosResultado);
            Resultado.Controls.Add(LitrosNeces);
            Resultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Resultado.Location = new Point(393, 36);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(341, 303);
            Resultado.TabIndex = 13;
            Resultado.TabStop = false;
            Resultado.Text = "Resultado da Simulação";
            // 
            // lblCustoResultado
            // 
            lblCustoResultado.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustoResultado.Location = new Point(14, 161);
            lblCustoResultado.Multiline = true;
            lblCustoResultado.Name = "lblCustoResultado";
            lblCustoResultado.ReadOnly = true;
            lblCustoResultado.Size = new Size(304, 42);
            lblCustoResultado.TabIndex = 14;
            lblCustoResultado.Text = "R$ 0,00";
            lblCustoResultado.TextAlign = HorizontalAlignment.Center;
            lblCustoResultado.TextChanged += CustoTotal_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 143);
            label4.Name = "label4";
            label4.Size = new Size(124, 30);
            label4.TabIndex = 13;
            label4.Text = "Custo Total Estimado:\r\n\r\n";
            // 
            // lblLitrosResultado
            // 
            lblLitrosResultado.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLitrosResultado.ForeColor = SystemColors.InfoText;
            lblLitrosResultado.Location = new Point(14, 57);
            lblLitrosResultado.Multiline = true;
            lblLitrosResultado.Name = "lblLitrosResultado";
            lblLitrosResultado.ReadOnly = true;
            lblLitrosResultado.Size = new Size(304, 42);
            lblLitrosResultado.TabIndex = 12;
            lblLitrosResultado.Text = "0,00 Litros";
            lblLitrosResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // LitrosNeces
            // 
            LitrosNeces.AutoSize = true;
            LitrosNeces.Location = new Point(14, 39);
            LitrosNeces.Name = "LitrosNeces";
            LitrosNeces.Size = new Size(109, 15);
            LitrosNeces.TabIndex = 1;
            LitrosNeces.Text = "Litros Necessários:\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(756, 556);
            Controls.Add(Resultado);
            Controls.Add(Dados);
            Controls.Add(limpar);
            Controls.Add(calcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculadora de Viagem";
            Dados.ResumeLayout(false);
            Dados.PerformLayout();
            Resultado.ResumeLayout(false);
            Resultado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button calcular;
        private Button limpar;
        private TextBox txtPreco;
        private TextBox txtConsumo;
        private TextBox txtDitancia;
        private GroupBox Dados;
        private GroupBox Resultado;
        private TextBox lblCustoResultado;
        private Label label4;
        private TextBox lblLitrosResultado;
        private Label LitrosNeces;
    }
}
