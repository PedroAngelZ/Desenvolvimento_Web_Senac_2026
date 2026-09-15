using System.Globalization;

namespace Calculadora_de_Viagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustoTotal_TextChanged(object sender, EventArgs e)
        {

        }

   
        

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtConsumo.Clear();
            txtDitancia.Clear();
            txtPreco.Clear();

            lblLitrosResultado.Text = "0,00 Litros";
            lblCustoResultado.Text = "R$ 0,00";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validação usando tryparse
            if(!double.TryParse(txtDitancia.Text, out double distancia) ||
                !double.TryParse(txtConsumo.Text, out double consumo) ||
                !double.TryParse(txtPreco.Text, out double preco))
            {
                MessageBox.Show("Preencha todos os campos com valores númericos validos!",
                    "Erro de Entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            //Regra de negócio: Impedir a divisão por zero
            if (consumo <= 0) {
                MessageBox.Show("O consumo médio deve ser maior que zero.", 
                    "Valor Invalido", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }
            //Calculo 
            double LitrosTotais = distancia / consumo;
            double CustoTotal = LitrosTotais * preco;


            lblLitrosResultado.Text = LitrosTotais.ToString("F2") + " Litros";
            lblCustoResultado.Text = "R$ " + CustoTotal.ToString("F2", CultureInfo.InvariantCulture).Replace(".", ",");


        }
    }
}
