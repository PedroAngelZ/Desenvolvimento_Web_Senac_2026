using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ExemplosAdicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // chama os exemplos de código
            string opcao;
            do
            {
                ExibirExemplos();
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Painel();
                        break;
                    case "2":
                        CalculoImposto();
                        break;
                    case "3":
                        Rosquinha();
                        break;
                    case "4":
                        Vetor();
                        break;
                    case "5":
                        Garagem();
                        break;
                    case "6":
                        Ascii();
                        break;
                    case "7":
                        Sobrecarga();
                        break;
                    case "8":
                        Contagem();
                        break;
                    case "9":
                        verificadordeIdade();
                        break;
                    case "10":
                        Jogo();
                        break;
                    case "11":
                        Rpg();
                        break;
                    case "0":
                        Console.WriteLine("Saindo do codigo de exemplos. Até mais!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Tente Novamente");
                        break;
                }

            } while (opcao != "s");

            static void ExibirExemplos()
            {
                Console.WriteLine("=======================================================");
                Console.WriteLine("||  Exemplos mostrados e pesquisados durante a aula  ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("[1] - Painel de Login  [2] - Imposto  [3] - Rosquinha ");
                Console.WriteLine("[4] - Vetor            [5] - Garagem  [6] - ASCII ");
                Console.WriteLine("[7] - Fritar           [8] - Contagem [9] - Idade");
                Console.WriteLine("[10]- Jogo Adivinhação [11]- RPG      [0] - Sair   ");
                Console.WriteLine("=======================================================");

            }
            // Exemplos de códigos
            static void Painel()
            {
                string usuario = "admin";

                string senha = "admin";

                int tentativas = 0;

                bool logado = false;

                Console.Title = "SISTEMA COMPLETO DE LOGIN";

                while (true)

                {

                    Console.Clear();

                    Console.WriteLine("======================================");

                    Console.WriteLine("      SISTEMA COMPLETO DE LOGIN");

                    Console.WriteLine("======================================");

                    Console.WriteLine("1 - Fazer Login");

                    Console.WriteLine("2 - Alterar Senha");

                    Console.WriteLine("3 - Informações");

                    Console.WriteLine("4 - Sair");

                    Console.WriteLine("======================================");

                    Console.Write("Escolha uma opção: ");

                    string opcao = Console.ReadLine();

                    switch (opcao)

                    {

                        case "1":

                            tentativas = 0;

                            logado = false;

                            while (tentativas < 3)

                            {

                                Console.Clear();

                                Console.WriteLine("========== LOGIN ==========");

                                Console.Write("Usuário: ");

                                string u = Console.ReadLine();

                                Console.Write("Senha: ");

                                string s = Console.ReadLine();

                                if (u == usuario && s == senha)

                                {

                                    Console.WriteLine();

                                    Console.WriteLine("ACESSO AUTORIZADO!");

                                    Console.WriteLine("Bem-vindo Administrador.");

                                    logado = true;

                                    Console.ReadKey();

                                    while (logado)

                                    {

                                        Console.Clear();

                                        Console.WriteLine("==================================");

                                        Console.WriteLine("      PAINEL DO ADMINISTRADOR");

                                        Console.WriteLine("==================================");

                                        Console.WriteLine("1 - Ver Dados");

                                        Console.WriteLine("2 - Data e Hora");

                                        Console.WriteLine("3 - Alterar Senha");

                                        Console.WriteLine("4 - Logout");

                                        Console.WriteLine("==================================");

                                        Console.Write("Escolha: ");

                                        string menu = Console.ReadLine();

                                        if (menu == "1")

                                        {

                                            Console.Clear();

                                            Console.WriteLine("USUÁRIO: " + usuario);

                                            Console.WriteLine("SENHA: " + senha);

                                            Console.ReadKey();

                                        }

                                        else if (menu == "2")

                                        {

                                            Console.Clear();

                                            Console.WriteLine("DATA: " + DateTime.Now.ToShortDateString());

                                            Console.WriteLine("HORA: " + DateTime.Now.ToLongTimeString());

                                            Console.ReadKey();

                                        }

                                        else if (menu == "3")

                                        {

                                            Console.Clear();

                                            Console.Write("Digite a senha atual: ");

                                            string atual = Console.ReadLine();

                                            if (atual == senha)

                                            {

                                                Console.Write("Digite a nova senha: ");

                                                senha = Console.ReadLine();

                                                Console.WriteLine("Senha alterada com sucesso!");

                                            }

                                            else

                                            {

                                                Console.WriteLine("Senha atual incorreta!");

                                            }

                                            Console.ReadKey();

                                        }

                                        else if (menu == "4")

                                        {

                                            Console.WriteLine("Logout realizado.");

                                            logado = false;

                                            Console.ReadKey();

                                        }

                                        else

                                        {

                                            Console.WriteLine("Opção inválida.");

                                            Console.ReadKey();

                                        }


                                    }

                                    break;

                                }

                                else

                                {

                                    tentativas++;

                                    Console.WriteLine();

                                    Console.WriteLine("ACESSO NEGADO!");

                                    Console.WriteLine("Usuário ou senha incorretos.");

                                    Console.WriteLine("Tentativa " + tentativas + " de 3.");

                                    Console.ReadKey();

                                }

                            }

                            if (!logado && tentativas == 3)

                            {

                                Console.Clear();

                                Console.WriteLine("==================================");

                                Console.WriteLine("SISTEMA BLOQUEADO!");

                                Console.WriteLine("Você excedeu o limite de tentativas.");

                                Console.WriteLine("==================================");

                                Console.ReadKey();

                            }

                            break;

                        case "2":

                            Console.Clear();

                            Console.Write("Digite a senha atual: ");

                            string senhaAtual = Console.ReadLine();

                            if (senhaAtual == senha)

                            {

                                Console.Write("Digite a nova senha: ");

                                senha = Console.ReadLine();

                                Console.WriteLine("Senha alterada com sucesso!");

                            }

                            else

                            {

                                Console.WriteLine("Senha incorreta!");

                            }

                            Console.ReadKey();

                            break;

                        case "3":

                            Console.Clear();

                            Console.WriteLine("==================================");

                            Console.WriteLine("SISTEMA DE LOGIN");

                            Console.WriteLine("Versão: 1.0");

                            Console.WriteLine("Usuário padrão: admin");

                            Console.WriteLine("Senha padrão: admin");

                            Console.WriteLine("Máximo de tentativas: 3");

                            Console.WriteLine("==================================");

                            Console.ReadKey();

                            break;

                        case "4":

                            Console.Clear();

                            Console.WriteLine("Obrigado por utilizar o sistema.");

                            Console.WriteLine("Encerrando...");

                            return;

                        default:

                            Console.WriteLine("Opção inválida!");

                            Console.ReadKey();

                            break;

                    }

                }


            }
            static void Vetor()
            {
                //vetor para armazenar os números
                int[] numeros = new int[10];
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    //numeros[i] =int.Parse(Console.ReadLine());
                    //ou
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }
                //Calcular a Soma dos números
                int soma = 0;
                //USANDO O FOR 
                for (int i = 0; i < numeros.Length; i++)
                {
                    soma += numeros[i];
                    //mesma coisa
                    // soma = soma + numeros[i];
                }
                Console.WriteLine("A soma dos números digitados é: " + soma);

                //usando o método Sum() da classe System.Linq
                int soma2 = numeros.Sum();
                Console.WriteLine("A soma dos números digitados é: " + soma2);

                //Usando o Foreach
                int soma3 = 0;
                foreach (int numero in numeros)
                {
                    soma3 += numero;
                }
                Console.WriteLine("A soma dos números digitados é: " + soma3);

            }
            static void CalculoImposto()
            {
                {
                    Mensagem();
                    double salario = LerSalario();
                    double imposto = CalcularImposto(salario);
                    double salarioliquido = CalcularSalarioLiquido(salario, imposto);

                    ExibirResultado(salario, imposto, salarioliquido);
                    Console.ReadKey();

                }

                static void Mensagem()
                {
                    Console.WriteLine("=========================");
                    Console.WriteLine("     Calculo do INSS     ");
                    Console.WriteLine("=========================");
                }
                static double LerSalario()
                {
                    Console.WriteLine("Digite o salario bruto: R$");
                    return Convert.ToDouble(Console.ReadLine());
                }
                static double CalcularImposto(double salario)
                {
                    double imposto;
                    if (salario <= 2428.80)
                    {
                        imposto = 0;
                    }
                    else if (salario <= 2826.65)
                    {
                        imposto = salario * 0.075;
                    }
                    else if (salario <= 3751.05)
                    {
                        imposto = salario * 0.15;
                    }
                    else if (salario <= 4664.68)
                    {
                        imposto = salario * 0.0225;
                    }
                    else
                    {
                        imposto = salario * 0.275;
                    }
                    return imposto;
                }
                static double CalcularSalarioLiquido(double salario, double imposto)
                {
                    return salario - imposto;
                }
                static void ExibirResultado(
                    double salario,
                    double imposto,
                    double salarioliquido)
                {
                    Console.WriteLine();
                    Console.WriteLine("======= RESULTADO =========");
                    Console.WriteLine($"salario bruto: R${salario:F2}");
                    Console.WriteLine($"imposto: R${imposto:F2}");
                    Console.WriteLine($"Salario Liquido: R${salarioliquido}");
                }
            }
            static void Rosquinha()
            {


                Console.Clear();

                const int WIDTH = 80;
                const int HEIGHT = 24;

                // Ângulos de rotação

                float A = 0.0f;
                float B = 0.0f;


                // Caracteres usados para representar
                // diferentes níveis de iluminação.

                string caracteres = ".,-~:;=!*#$@";


                // Tela:
                // Guarda todos os caracteres que serão exibidos.

                char[] tela = new char[WIDTH * HEIGHT];


                // Z-buffer:
                // Guarda a profundidade de cada ponto.

                float[] profundidade = new float[WIDTH * HEIGHT];


                // Configura o console.

                Console.OutputEncoding = Encoding.UTF8;


                // Esconde o cursor.

                Console.CursorVisible = false;


                // Loop principal da animação.

                while (true)
                {

                    // Limpa a tela
                    // ' ' = espaço vazio.

                    Array.Fill(tela, ' ');


                    // Limpa o Z-buffer.
                    // 0 significa que ainda não existe nenhum ponto naquela posição.

                    Array.Fill(profundidade, 0.0f);


                    // Percorre o ângulo J.

                    for (float j = 0.0f; j < 6.28f; j += 0.07f)
                    {
                        
                        // Percorre o ângulo I.
                        for (float i = 0.0f; i < 6.28f; i += 0.02f)
                        {
                            
                            // Calcula seno e cosseno dos ângulos.
                           
                            float senoI = MathF.Sin(i);
                            float cosI = MathF.Cos(i);

                            float senoJ = MathF.Sin(j);
                            float cosJ = MathF.Cos(j);

                            
                            // Calcula seno e cosseno dos ângulos de rotação.
                            
                            float senoA = MathF.Sin(A);
                            float cosA = MathF.Cos(A);

                            float senoB = MathF.Sin(B);
                            float cosB = MathF.Cos(B);

                            
                            //   Raio da parte circular da rosquinha.
                            
                            float h = cosJ + 2.0f;

                            
                            //  Calcula a profundidade.
                            
                            float D =
                                1.0f /
                                (
                                    senoI * h * senoA +
                                    senoJ * cosA +
                                    5.0f
                                );

                            
                            //  Calcula uma coordenada intermediária.
                            
                            float t =
                                senoI * h * cosA -
                                senoJ * senoA;

                            
                            //  Calcula a posição X na tela.
                            
                            int x =
                                (int)
                                (
                                    WIDTH / 2.0f +
                                    30.0f *
                                    D *
                                    (
                                        cosI * h * cosB -
                                        t * senoB
                                    )
                                );

                            
                            //  Calcula a posição Y na tela.
                            
                            int y =
                                (int)
                                (
                                    HEIGHT / 2.0f +
                                    15.0f *
                                    D *
                                    (
                                        cosI * h * senoB +
                                        t * cosB
                                    )
                                );

                            
                             // Verifica se o ponto está dentro da tela.
       
                            if (x < 0 || x >= WIDTH ||
                                y < 0 || y >= HEIGHT)
                            {
                                continue;
                            }
                             
                            // Converte X e Y em uma posição única no vetor.
                            
                            int indice = x + WIDTH * y;

                            // Calcula a iluminação da superfície.
                            
                            float iluminacao =
                                8.0f *
                                (
                                    (
                                        senoJ * senoA -
                                        senoI * cosJ * cosA
                                    )
                                    * cosI
                                    -
                                    senoI * cosJ * senoA
                                    -
                                    senoJ * cosA
                                );

                            // Verifica se este ponto está mais próximo da câmera.
                            
                            if (D > profundidade[indice])
                            {
                                
                                // Salva a profundidade.
                                
                                profundidade[indice] = D;

                                
                               // Converte a iluminação para um índice de caractere.
                                
                                int nivel = (int)iluminacao;

                                
                                //  Evita índice negativo.
                                
                                if (nivel < 0)
                                {
                                    nivel = 0;
                                }

                                
                                //  Existem 12 caracteres. Índices válidos: 0 até 11.
                                
                                if (nivel > 11)
                                {
                                    nivel = 11;
                                }

                                
                                //  Escolhe o caractere correspondente à iluminação.
                                
                                tela[indice] = caracteres[nivel];
                            }
                        }
                    }

                    
                    //  Volta o cursor para o canto superior esquerdo.
                    
                    Console.SetCursorPosition(0, 0);

                    
                    //   Imprime a tela.
                   
                    for (int y = 0; y < HEIGHT; y++)
                    {
                        for (int x = 0; x < WIDTH; x++)
                        {
                            Console.Write(tela[x + WIDTH * y]);
                        }

                        Console.WriteLine();
                    }

                    // Atualiza a rotação.

                    //   A = rotação em um eixo.
                    //   B = rotação em outro eixo.
                    
                    A += 0.04f;
                    B += 0.02f;

                    
                    //  Controla a velocidade da animação.
                   
                    Thread.Sleep(30);
                }


               
            }
            static void Sobrecarga()
            {
                Console.WriteLine("Atenção: Isso vai fazer seu processador pedir ajuda!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                int totalNucleos = Environment.ProcessorCount;
                Console.WriteLine($"Mandando infinitos loops em: {totalNucleos} threads simultâneas...");

                // inicia um thread para cada núcleo do processador
                // Multiplicamos os nucleos por 4 para sobrecarregar ainda mais o processador
                int totalThreads = Environment.ProcessorCount * 4;
                Console.WriteLine($"Disparando {totalThreads} threads para esmagar a CPU...");

                for (int i = 0; i < totalThreads; i++)
                {
                    Thread t = new Thread(() =>
                    {
                        double x = 0.0001; // Valor inicial para o cálculo
                        while (true)
                        {
                            // Cálculo matemático pesado para sobrecarregar a CPU
                            x = Math.Sqrt(x) * Math.Sin(x) * Math.Cos(x);
                        }
                    });

                    // Define prioridade máxima para a thread roubar ciclo de clock da CPU
                    t.Priority = ThreadPriority.Highest;
                    t.Start();

                }
                Console.WriteLine("Alerta: CPU pedindo ajuda!");
                Console.WriteLine("O poder do sol na palma da sua mão!");
                

            }
            static void Ascii()
            {
                // Alguns testes de ASCII Art, para entender como funciona.

                Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine(@"
                ⣿⣿⣿⣿⣿⣿⣿⣿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿
                ⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢺⣿
                ⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠆⠜⣿
                ⣿⣿⣿⣿⠿⠿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿
                ⣿⣿⡏⠁⠀⠀⠀⠀⠀⣀⣠⣤⣤⣶⣶⣶⣶⣶⣦⣤⡄⠀⠀⠀⠀⢀⣴⣿
                ⣿⣿⣷⣄⠀⠀⠀⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⡧⠇⢀⣤⣶
                ⣿⣿⣿⣿⣿⣿⣾⣮⣭⣿⡻⣽⣒⠀⣤⣜⣭⠐⢐⣒⠢⢰
                ⣿⣿⣿⣿⣿⣿⣿⣏⣿⣿⣿⣿⣿⣿⡟⣾⣿⠂⢈⢿⣷⣞
                ⣿⣿⣿⣿⣿⣿⣿⣿⣽⣿⣿⣷⣶⣾⡿⠿⣿⠗⠈⢻⣿
                ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠻⠋⠉⠑⠀⠀⢘⢻
                ⣿⣿⣿⣿⣿⣿⣿⡿⠟⢹⣿⣿⡇⢀⣶⣶⠴⠶⠀⠀⢽
                ⣿⣿⣿⣿⣿⣿⡿⠀⠀⢸⣿⣿⠀⠀⠣⠀⠀⠀⠀⠀⡟⢿⣿
                ⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠹⣿⣧⣀⠀⠀⠀⠀⡀⣴⠁⢘⡙
                ⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠈⠙⢿⠗⠂⠄⠀⣴⡟⠀⠀⡃");
                Console.WriteLine("              === JESSE WE NEED TO COOK ===     ");

                Console.WriteLine();
                Console.WriteLine(@"
                ⢋⣴⠒⡝⣿⣿⣿⣿⣿⡿⢋⣥⣶⣿⣿⣿⣿⣿⣿⣶⣦⣍⠻⣿⣿⣿⣿⣿⣷⣿
                ⢾⣿⣀⣿⡘⢿⣿⡿⠋⠄⠻⠛⠛⠛⠻⠿⣿⣿⣿⣿⣿⣿⣷⣌⠻⣿⣿⣿⣿⣿
                ⠄⠄⠈⠙⢿⣦⣉⡁⠄⠄⣴⣶⣿⣿⢷⡶⣾⣿⣿⣿⣿⡛⠛⠻⠃⠙⢿⣿⣿⣿
                ⠄⠄⠄⠄⠄⠈⠉⣀⣀⣴⡟⢩⠁⠩⣝⢂⢨⣿⣿⣿⣿⢟⡛⣳⣶⣤⡘⠿⢋⣡
                ⠄⠄⠄⠄⠄⠄⠘⣿⣿⣿⣿⣾⣿⣶⣿⣿⣿⣿⣿⣿⣿⣆⣈⣱⣮⣿⣷⡾⠟⠋
                ⠄⠄⠄⠄⠄⠄⠄⠈⠿⠛⠛⣻⣿⠉⠛⠋⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠸⣿
                ⠄⠄⠄⠄⢀⡠⠄⢒⣤⣟⠿⣿⣿⣿⣷⣤⣤⣀⣀⣉⣉⣠⣽⣿⣟⠻⣿⣿⡆⢻
                ⠄⣀⠄⠄⠄⠄⠈⠋⠉⣿⣿⣶⣿⣟⣛⡿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣼⣿⡇⣸
                ⣿⠃⠄⠄⠄⠄⠄⠄⠠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣶⣾⣿⣿⣿⣿⣿⣿⠁⢿
                ⡋⠄⠄⠄⠄⠄⠄⢰⣷⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠄⠄ ");

                Console.WriteLine();
                Console.WriteLine(@"
                ⣿⣿⣿⡟⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠙⣿⣿⣿⣿
                ⣿⣿⣿⠁⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⢿⣿⣿
                ⣿⣿⡇⠄⠄⠄⠄⠄⠄⢀⣀⣀⣤⣶⣦⣤⣤⣤⣤⣄⣄⠄⠸⣿⣿
                ⣿⣿⠁⠄⠄⢀⣠⣾⣿⣿⣥⣤⣶⣶⡖⢻⣿⣿⡥⣤⣤⣉⣦⢹⣿
                ⣿⣿⡆⠄⠄⣿⣿⣿⣿⣿⣿⢽⠉⠙⣻⣿⣿⣿⣶⢟⠛⢻⡇⢸⣿
                ⣿⣿⣿⠄⠄⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢻⣿⣷⣾⣿⡈⣿
                ⣿⣿⣿⣷⣸⣿⣿⠸⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣄⠙⣿⣿⣿⠇⣿
                ⠉⠉⠉⠉⠁⣿⣿⣆⠹⣿⣿⣿⣿⣿⣄⣹⣏⣿⡋⣸⣿⣿⠟⣰⣿
                ⠄⠄⠄⠄⠄⣿⣿⣿⣷⣌⠛⢿⣿⣏⣉⠛⠛⠛⠛⢻⣿⡇⣾⣿⣿
                ⠄⠄⠄⠄⢸⣿⣿⣯⣿⣿⣷⣄⠙⢿⣿⣿⣿⣷⣦⡀⠙⡴⢟⣿⣿
                ⠄⠄⠄⢠⣿⣿⣟⣯⣿⣿⣿⣿⣿⣶⣤⣉⣉⠉⠉⠰⣷⣼⣿⣿⣿ ");

                Console.WriteLine();
                Console.WriteLine(@"⠀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣻⣿⡿⢛⠿⠿⢿⣦⣤⣦⣀⣀
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢤⡀⠀⡠⠚⣭⡛⡳⠶⠥⠾⠿⣿⣿⣏⠙⢿⡟
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠦⢗⡶⠿⣾⣀⣸⣿⢿⣿⣿⣿⣿⣿⣿⣧
                ⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀ ⣀⠠⠤⠾⠿⠿⣮⣛⢛⣉⣭⣿⣿⣿⣿⣿⣿⣿⡟
                ⠀⠀⠀⠀⠀⠀⠀⢰⡟⠁⠘⠃⠀⠀⠀⠘⠁⠈⠙⠳⡝⢿⣿⣿⣿⣿⣿⣿⣿⡆⠀⣀
                ⠀⠀⠀⠀⠀⠀⠀⠈⠙⠒⠒⣒⣂⣶⣾⣿⣿⣿⣿⣶⡾⡦⣻⣦⣼⣿⣿⣿⣿⡅⠈⠿⠟⠳⢦
                ⠀⠀⠀⠀⠀⠀⠀⢀⣠⠴⠂⢻⣿⣿⣿⣿⣿⣿⣿⣿⣷⣴⣿⣿⣿⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀⠙⠳⢄
                ⠀⣠⣶⣶⣦⡴⠚⠉⠀⠀⠀⠀⠙⢿⣿⣿⣿⣿⣿⡿⣣⣿⣿⣿⣿⣿⡿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠉⠢⣄
                ⠞⠉⠀⠋⠀⠈⣦⠀⠀⠀⠀⠀⠀⠀⣭⣛⣛⣛⠉⠺⠿⠿⢿⣿⣿⣿⣤⣤⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠾⠋⠉⠉⠻⡟⢯⢆
                 ");



                Console.ReadKey();

            }
            static void Contagem()
            {
                // Contagem regressiva de 100000 até -100000
                for (int i = 100000; i >= -100000; i--)
                {
                    Console.WriteLine($"Eu comi o cu de quem está lendo n°{i}");
                }
            }
            static void verificadordeIdade() 
            {
                int idade = 17;
                string tipoingresso;
                Console.WriteLine("==== Verificador de Idade ============================="); 
                Console.WriteLine($"Idade informada: {idade} anos");
                // primeira verificação
                if (idade < 18)
                {
                    Console.WriteLine("Você é menor de idade e não pode entrar.");
                }
                else if (idade >= 18 && idade < 21)
                {
                    tipoingresso = "meia";
                    Console.WriteLine($"Você é maior de idade, mas não tem 21 anos. Seu ingresso é do tipo: {tipoingresso}");
                }
                else
                {
                    tipoingresso = "inteira";
                    Console.WriteLine($"Você é maior de idade e tem 21 anos ou mais. Seu ingresso é do tipo: {tipoingresso}");
                }
                Console.WriteLine("==== Fim do Verificador ===============================");

                // == igualdade 
                // > maior
                // >= maior ou igual
                // < menor
                // <= menor ou igual
                // != diferente
                // && e
                // || ou
            }
            static void Jogo()
            {
                // Jogo de adivinhação
                Random random = new Random();
                int numeroSecreto = random.Next(1, 101);
                int tentativas = 0;
                int palpite = 0;
                Console.WriteLine("==== Jogo de Adivinhação ====");
                Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");
                while (palpite != numeroSecreto)
                {
                    Console.Write("Digite seu palpite: ");
                    palpite = Convert.ToInt32(Console.ReadLine());
                    tentativas++;
                    if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("Muito baixo! Tente novamente.");
                    }
                    else if (palpite > numeroSecreto)
                    {
                        Console.WriteLine("Muito alto! Tente novamente.");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns! Você acertou o número secreto {numeroSecreto} em {tentativas} tentativas.");
                    }
                }
            }
            static void Rpg()
            {

            }

        }

        static void Garagem()
        {
            Console.WriteLine("==== Carros na Garagem ====");

            // Criando uma Instância da garagem
            garagem minhaGaragem = new garagem();
            minhaGaragem.NomeResponsavel = "Pedrão da ZL";
            Carro c1 = new Carro { Modelo = "Fusca", Cor = "Azul" };
            Carro c2 = new Carro { Modelo = "Gol", Cor = "Preto" };
            Carro c3 = new Carro { Modelo = "Civic", Cor = "Prata" };

            // Estacionamento os carros na garagem
            minhaGaragem.EstacionarCarro(c1);
            minhaGaragem.EstacionarCarro(c2);
            minhaGaragem.EstacionarCarro(c3);

            minhaGaragem.ExibirCarros();

        }
        class Carro
        {

            public string Modelo { get; set; }
            public string Cor { get; set; }

            // Método para exibir informações do carro formatadas
            public void ExibirDetalhes()
            {
                Console.WriteLine($"- Carro: {Modelo} / cor: {Cor}");
            }
        }
        class garagem
        {
            public string NomeResponsavel { get; set; }
            private List<Carro> CarroList = new List<Carro>();

            // Método para estacionar um carro
            public void EstacionarCarro(Carro carro)
            {
                CarroList.Add(carro);
                Console.WriteLine($"{carro.Modelo} foi estacionado!");

            }
            // Método para exibir todos os carros
            public void ExibirCarros()
            {
                // Aqui exibe os responsavel e os carros
                Console.WriteLine($"\nResponsável: {NomeResponsavel}");
                Console.WriteLine("Carros estacionados:");

                // Utilizando o foreach ele percorre diretamente sobre os elementos da coleção sem precisar do Índice
                foreach (Carro carro in CarroList)
                {
                    carro.ExibirDetalhes();
                }
            }


            // Método de Remover o veiculo
            public void RemoverCarro(string modelo)
            {
                Carro carro = CarroList.Find(c => c.Modelo == modelo);

                if (carro != null)
                {
                    CarroList.Remove(carro);
                    Console.WriteLine($"{modelo} foi removido da garagem!");
                }
                else
                {
                    Console.WriteLine($"O carro {modelo} não está na garagem.");
                }
            }
            // POO - Programação Orientada a Objetos

        }

    }
}

