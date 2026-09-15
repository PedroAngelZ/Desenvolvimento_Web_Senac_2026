namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        private double primeiroValor = 0;
        private string operacaoAtual = "";
        private bool limparVisor = false;
        private double memoria = 0;
        private string expressao = "";
        public Form1()
        {
            InitializeComponent();


        }
        // todos os botões númericos (0 a 9)
        private void BotaoNumero_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            string digito = botao.Text;

            //Limpar o visor se for o primeiro digito ou se uma operação foi selecionada
            if (txtDisplay.Text == "0" || limparVisor)
            {
                txtDisplay.Text = digito;
                limparVisor = false;
            }
            else
            {
                txtDisplay.Text += digito;
            }
        }

        // As quatro operações
        private void BotaoOperacao_Click(object sender, EventArgs e)
        {

            Button botao = (Button)sender;

            // Se uma operação já foi selecionada e o visor precisa ser limpo, atualiza a operação
            if (operacaoAtual != "" && limparVisor)
            {
                operacaoAtual = botao.Text;
                expressao = txtDisplay.Text + " " + operacaoAtual;
                lblHistorico.Text = expressao;
                return;
            }
            // Salva o valor atual e a operação escolhida
            primeiroValor = double.Parse(txtDisplay.Text);
            operacaoAtual = botao.Text;

            expressao = txtDisplay.Text + " " + operacaoAtual;
            lblHistorico.Text = expressao;

            //Sinalizar que o proximo digito a
            limparVisor |= true;
        }
        // Aqui é botão do = que mostra o resultado
        private void BotaoIgual_Click(object sender, EventArgs e)
        {
            if (operacaoAtual == "" || operacaoAtual == "Erro") return; // Nenhuma operação selecionada ou travado por erro

            double segundoValor = double.Parse(txtDisplay.Text);

            lblHistorico.Text = expressao + " " + segundoValor.ToString() + " =";
            double resultado = 0;


            switch (operacaoAtual)
            {
                case "+":
                    resultado = primeiroValor + segundoValor;
                    break;

                case "-":
                    resultado = primeiroValor - segundoValor;
                    break;

                case "x":
                
                    resultado = primeiroValor * segundoValor;
                    break;
                case "÷":
                    if (segundoValor == 0)
                    {
                        // Por algum motivo quando eu coloco uma frase maior no Erro, fica cortado no programa quando o usuario tenta dividir por zero
                        txtDisplay.Text = "Erro";
                        operacaoAtual = "Erro";
                        limparVisor = true;
                        return;
                    }
                    resultado = primeiroValor / segundoValor;
                    break;

                default:
                    resultado = segundoValor;
                    break;
            }

            txtDisplay.Text = resultado.ToString();
            operacaoAtual = "";
            limparVisor = true; 
        }
        

        // Aqui é o botão C que limpa tudo
        private void BotaoLimparTudo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            primeiroValor = 0;
            operacaoAtual = "";
            expressao = "";
            lblHistorico.Text = "";
            limparVisor = false;
        }


        // botao CE que limpa entrada
        private void BotaoLimparEntrada_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }


        // botão backspace que apaga o último dígito
        private void BotaoBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            else
                txtDisplay.Text = "0";
        }

        // Botão de vírgula
        private void BotaoVirgula_Click(object sender, EventArgs e)
        {
            // a virgula eu fiz diferente da aula ficou mais simples
                if (!txtDisplay.Text.Contains(","))
                txtDisplay.Text += ",";
        }

        // botão de inverter sinal para positivo/negativo
        private void BotaoInverterSinal_Click(object sender, EventArgs e)
        {
            double valorAtual = double.Parse(txtDisplay.Text);
            valorAtual *= -1;
            txtDisplay.Text = valorAtual.ToString();
        }

        // Porcentagem
        private void BotaoPorcentagem_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (valor / 100).ToString();
        }

        // Quadrado
        private void BotaoQuadrado_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (valor * valor).ToString();
        }

        // Raiz
        private void BotaoRaiz_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtDisplay.Text);
            if (valor < 0)
            {
                MessageBox.Show("Não é possível calcular a raiz quadrada de um número negativo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtDisplay.Text = Math.Sqrt(valor).ToString();
        }

        // Inverso
        private void BotaoInverso_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtDisplay.Text);
            if (valor == 0)
            {
                MessageBox.Show("Não é possivel dividir por zero");
                return;
            }
            txtDisplay.Text = (1 / valor).ToString();
        }

        // Memória da calculadora //

        // Botão MC, MR, M+, M-, MS, Mv
        // Ms e Mv não funcionam tão bem, porque não entendi muito eu pesquisei e tentei funcionar mas não sei se está certo


        // Memory Clear
        private void BotaoMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        // Memory Recall
        private void BotaoMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoria.ToString();
            limparVisor = true;

        }

        // Memory Add
        private void BotaoMmais_Click(object sender, EventArgs e)
        {
            memoria += double.Parse(txtDisplay.Text);
        }

        // Memory Subtract
        private void BotaoMmenos_Click(object sender, EventArgs e)
        {
            memoria -= double.Parse(txtDisplay.Text);
        }

        // Memory Store
        private void BotaoMS_Click(object sender, EventArgs e)
        {
            memoria = double.Parse(txtDisplay.Text);
        }

        // Memory List
        private void BotaoMv_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoria.ToString();
            limparVisor = true;
        }
    }
}
