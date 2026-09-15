using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ListaExercicios
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string opcao;
            do
            {
                //aqui chamamos os exercicios
                ExibirMenu();
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        // Exercicio1();
                        Exercicio1();
                        break;
                    case "2":
                        // Exercicio2();
                        Exercicio2();
                        break;
                    case "3":
                        // Exercicio3();
                        Exercicio3();
                        break;
                    case "4":
                        // Exercicio4();
                        Exercicio4();
                        break;
                    case "5":
                        // Exercicio5();
                        Exercicio5();
                        break;
                    case "6":
                        // Exercicio6();
                        Exercicio6();
                        break;
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "9":
                        Exercicio9();
                        break;
                    case "10":
                        Exercicio10();
                        break;
                    case "11":
                        Exercicio11();
                        break;
                    case "12":
                        Exercicio12();
                        break;
                    case "13":
                        Exercicio13();
                        break;
                    case "14":
                        Exercicio14();
                        break;
                    case "15":
                        Exercicio15();
                        break;
                    case "16":
                        Exercicio16();
                        break;
                    case "17":
                        Exercicio17();
                        break;
                    case "18":
                        Exercicio18();
                        break;
                    case "19":
                        Exercicio19();
                        break;
                    case "20":
                        Exercicio20();
                        break;
                    case "21":
                        Exercicio21();
                        break;
                    case "22":
                        Exercicio22();
                        break;
                    case "23":
                        Exercicio23();
                        break;
                    case "24":
                        Exercicio24();
                        break;
                    case "25":
                        Exercicio25();
                        break;
                    case "26":
                        Exercicio26();
                        break;
                    case "27":
                        Exercicio27();
                        break;
                    case "28":
                        Exercicio28();
                        break;
                    case "29":
                        Exercicio29();
                        break;
                    case "30":
                        Exercicio30();
                        break;
                    case "31":
                        Exercicio31();
                        break;
                    case "32":
                        Exercicio32();
                        break;
                    case "33":
                        Exercicio33();
                        break;
                    case "34":
                        Exercicio34();
                        break;
                    case "35":
                        Exercicio35();
                        break;
                    case "36":
                        Exercicio36();
                        break;
                    case "37":
                        Exercicio37();
                        break;
                    case "38":
                        Exercicio38();
                        break;
                    case "39":
                        Exercicio39();
                        break;
                    case "40":
                        Exercicio40();
                        break;
                    case "41":
                        Exercicio41();
                        break;
                    case "42":
                        Exercicio42();
                        break;
                    case "43":
                        Exercicio43();
                        break;
                    case "44":
                        Exercicio44();
                        break;
                    case "45":
                        Exercicio45();
                        break;
                    case "46":
                        Exercicio46();
                        break;
                    case "47":
                        Exercicio47();
                        break;
                    case "48":
                        Exercicio48();
                        break;
                    case "49":
                        Exercicio49();
                        break;
                    case "50":
                        Exercicio50();
                        break;
                    case "51":
                        Exercicio51();
                        break;
                    case "52":
                        Exercicio52();
                        break;
                    case "53":
                        Exercicio53();
                        break;
                    case "54":
                        Exercicio54();
                        break;
                    case "55":
                        Exercicio55();
                        break;
                    case "56":
                        Exercicio56();
                        break;
                    case "57":
                        Exercicio57();
                        break;
                    case "58":
                        Exercicio58();
                        break;
                    case "59":
                        Exercicio59();
                        break;
                    case "60":
                        Exercicio60();
                        break;
                    case "61":
                        Exercicio61();
                        break;
                    case "62":
                        Exercicio62();
                        break;
                    case "63":
                        Exercicio63();
                        break;
                    case "64":
                        Exercicio64();
                        break;
                    case "65":
                        Exercicio65();
                        break;
                    case "66":
                        Exercicio66();
                        break;
                    case "67":
                        Exercicio67();
                        break;
                    case "68":
                        Exercicio68();
                        break;
                    case "69":
                        Exercicio69();
                        break;
                    case "70":
                        Exercicio70();
                        break;
                    case "71":
                        Exercicio71();
                        break;
                    case "72":
                        Exercicio72();
                        break;
                    case "73":
                        Exercicio73();
                        break;
                    case "74":
                        Exercicio74();
                        break;
                    case "75":
                        Exercicio75();
                        break;
                    case "76":
                        Exercicio76();
                        break;
                    case "77":
                        Exercicio77();
                        break;
                    case "78":
                        Exercicio78();
                        break;
                    case "79":
                        Exercicio79();
                        break;
                    case "80":
                        Exercicio80();
                        break;
                    case "81":
                        Exercicio81();
                        break;
                    case "82":
                        Exercicio82();
                        break;
                    case "83":
                        Exercicio83();
                        break;
                    case "84":
                        Exercicio84();
                        break;
                    case "85":
                        Exercicio85();
                        break;
                    case "86":
                        Exercicio86();
                        break;
                    case "87":
                        Exercicio87();
                        break;
                    case "88":
                        Exercicio88();
                        break;
                    case "89":
                        Exercicio89();
                        break;
                    case "90":
                        Exercicio90();
                        break;
                    case "91":
                        Exercicio91();
                        break;
                    case "92":
                        Exercicio92();
                        break;
                    case "93":
                        Exercicio93();
                        break;
                    case "94":
                        Exercicio94();
                        break;
                    case "95":
                        Exercicio95();
                        break;
                    case "96":
                        Exercicio96();
                        break;
                    case "97":
                        Exercicio97();
                        break;
                    case "98":
                        Exercicio98();
                        break;
                    case "99":
                        Exercicio99();
                        break;
                    case "100":
                        Exercicio100();
                        break;
                    case "101":
                        Exercicio101();
                        break;
                    case "102":
                        Exercicio102();
                        break;
                    case "103":
                        Exercicio103();
                        break;
                    case "104":
                        Exercicio104();
                        break;
                    case "105":
                        Exercicio105();
                        break;
                    case "106":
                        Exercicio106();
                        break;
                    case "107":
                        Exercicio107();
                        break;
                    case "108":
                        Exercicio108();
                        break;
                    case "109":
                        Exercicio109();
                        break;
                    case "110":
                        Exercicio110();
                        break;
                    case "111":
                        Exercicio111();
                        break;
                    case "112":
                        Exercicio112();
                        break;
                    case "113":
                        Exercicio113();
                        break;
                    case "114":
                        Exercicio114();
                        break;
                    case "115":
                        Exercicio115();
                        break;
                    case "116":
                        Exercicio116();
                        break;
                    case "117":
                        Exercicio117();
                        break;
                    case "118":
                        Exercicio118();
                        break;
                    case "119":
                        Exercicio119();
                        break;
                    case "120":
                        Exercicio120();
                        break;
                    case "0":
                        Console.WriteLine("Saindo do Programa...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida. Tente Novamente");
                        break;

                }

            } while (opcao != "0");

            static void ExibirMenu()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("========== LINGUAGEM C# EXERCICIOS NO VISUAL STUDIO ==========");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURA SEQUENCIAL ======================================");
                Console.ResetColor();

                Console.WriteLine("[01] [02] [03] [04] [05] [06] [07] [08] [09] [10]");
                Console.WriteLine("[11] [12] [13] [14] [15] [16] [17] [18] [19] [20]");
                Console.WriteLine("[21] [22] [23] [24] [25] [26] ");


                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURA DE DECISÃO ======================================");
                Console.ResetColor();


                Console.WriteLine("[27] [28] [29] [30] [31] [32] [33] [34] [35] [36]");
                Console.WriteLine("[37] [38] [39] [40] [41] ");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURA DE REPETIÇÃO ====================================");
                Console.ResetColor();


                Console.WriteLine("[42] [43] [44] [45] [46] [47] [48] [49] [50] [51]");
                Console.WriteLine("[52] [53] [54] [55] [56] [57] [58] [59] [60]");



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURA DE DADOS DE UMA DIMENSÃO ========================");
                Console.ResetColor();


                Console.WriteLine("[61] [62] [63] [64] [65] [66] [67] [68] [69] [70]");
                Console.WriteLine("[71] [72] [73] [74] [75] [76] [77] [78] [79] [80]");
                Console.WriteLine("[81] [82] [83] [84] [85] [86] ");



                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURA DE DADOS DE DUAS DIMENSÕES ======================");
                Console.ResetColor();


                Console.WriteLine("[87] [88] [89] [90] [91] [92] [93] [94] [95] [96] [97] [98]");
                Console.WriteLine("[99] [100] [101] [102] [103] [104] [105] [106] [107] [108]");
                Console.WriteLine("[109]");





                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURAS HETEROGÊNEAS ===================================");
                Console.ResetColor();


                Console.WriteLine("[110] [111] [112] [113]");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("== ESTRUTURA SUB PROGRAMAS ===================================");
                Console.ResetColor();


                Console.WriteLine("[114] [115] [116] [117] [118] [119] [120]");


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("==============================================================");
                Console.ResetColor();

                Console.WriteLine("[0] - Sair");
                Console.WriteLine("Digite a opção desejada: ");


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==============================================================");
                Console.ResetColor();
            }

            // funções 
            static void Exercicio1()
            {

                Console.WriteLine("Exercicio 1: Conversão de Temperatura (Celsius para Fahrenheit)");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira a temperatura em graus Celsius.
                Console.WriteLine("Digite a temperatura em graus Celsius: ");
                double C, F;
                //    - Aguarde a entrada do usuário.
                C = Convert.ToDouble(Console.ReadLine());

                // 2. Processamento:
                //    - Utilize a fórmula de conversão de temperatura: F = C * 9/5 + 32, onde
                //      F é a temperatura em Fahrenheit e C é a temperatura em Celsius.
                //    - Calcule a temperatura em Fahrenheit usando a fórmula mencionada.
                F = C * 9 / 5 + 32;

                // 3. Saída de Dados:
                //    - Exiba a temperatura convertida em graus Fahrenheit.
                Console.WriteLine($"A temperatura em Fahrenheit é: {F} °F");
            }
            static void Exercicio2()
            {
                // Passo a Passo
                double F, C;

                Console.WriteLine("Exercicio 2: Converasão de Temperatura (Fahrenheit para Celsius)");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira a temperatura em graus Fahrenheit.
                Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
                //    - Aguarde a entrada do usuário.
                F = Convert.ToDouble(Console.ReadLine());

                // 2. Processamento:
                //    - Utilize a fórmula de conversão de temperatura: C = (F - 32) * 5/9, onde
                //      C é a temperatura em Celsius e F é a temperatura em Fahrenheit.
                //    - Calcule a temperatura em Celsius usando a fórmula mencionada.
                C = (F - 32) * 5 / 9;
                // 3. Saída de Dados:
                //    - Exiba a temperatura convertida em graus Celsius.
                Console.WriteLine($"A temperatura em Celsius é: {C} °C");
            }
            static void Exercicio3()
            {   // Passo a Passo:
                double raio, altura, volume;

                Console.WriteLine("Exercicio 3: Cálculo do Volume de uma Lata de Óleo");


                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o raio da base da lata em centímetros.
                Console.WriteLine("Digite o raio da base da lata em centimetros");
                raio = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira a altura da lata em centímetros.
                Console.WriteLine("Digite a altura da lata em centimetros");
                altura = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.


                // 2. Processamento:
                //    - Utilize a fórmula para calcular o volume da lata de óleo: V = π * raio^2 * altura,
                //      onde V é o volume, raio é o raio da base da lata e altura é a altura da lata.
                //    - Calcule o volume utilizando a fórmula mencionada. 

                //volume = 3.14 * (raio * raio) * altura;
                volume = Math.PI * Math.Pow(raio, 2) * altura;

                // 3. Saída de Dados:
                //    - Exiba o volume calculado da lata de óleo em centímetros cúbicos (cm³).
                Console.WriteLine($"O volume da lata de óleo é {volume} cm³");
            }
            static void Exercicio4()
            {
                double distancia, consumo, litros;

                Console.WriteLine("Exercicio 4: Cálculo da  Quantidade de Combustivel em uma Viagem ");
                // Codigo do Exercicio 4

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira a distância percorrida em quilômetros.
                Console.WriteLine("Digite a distância percorrida em quilomentros");
                distancia = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira o consumo do veículo em quilômetros por litro.
                Console.WriteLine("Digite o consumo do veiculo em quilomentros por litros");
                consumo = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Utilize a fórmula para calcular a quantidade de litros de combustível
                //      gasta na viagem: litros = distância / consumo, onde litros é a quantidade
                //      de litros de combustível gasta, distância é a distância percorrida em
                //      quilômetros e consumo é o consumo do veículo em quilômetros por litro.
                //    - Calcule a quantidade de litros de combustível gasta utilizando a fórmula mencionada.
                litros = distancia / consumo;

                // 3. Saída de Dados:
                //    - Exiba a quantidade de litros de combustível gasta na viagem.
                Console.WriteLine($"A quantidade de litros de combustivel na viagem foi de {litros} litros. ");

            }
            static void Exercicio5()
            {
                double valor, meses, juros, atraso;

                Console.WriteLine("Exercicio 5: Cálculo do Valor de uma Prestação em Atraso");
                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o valor original da prestação.
                Console.WriteLine("Digite o valor original da prestação");
                valor = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira o número de meses em atraso.
                Console.WriteLine("Digite o número de meses em atraso");
                meses = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira a taxa de juros mensal.
                Console.WriteLine("Digite a taxa de juros mensal");
                juros = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Utilize a fórmula para calcular o valor da prestação em atraso: 
                //      valor = valor_original * (1 + (taxa_juros / 100) * meses_atraso), 
                //      onde valor_original é o valor da prestação sem os juros, 
                //      taxa_juros é a taxa de juros mensal e 
                //      meses_atraso é o número de meses em atraso.
                //    - Calcule o valor da prestação em atraso usando a fórmula mencionada.
                atraso = valor * (1 + (juros / 100) * meses);

                // 3. Saída de Dados:
                //    - Exiba o valor da prestação em atraso.
                Console.WriteLine($"Está em atraso R${atraso}");
            }
            static void Exercicio6()
            {
                // Passo a Passo:
                double A, B;

                Console.WriteLine("Exercício 6: Troca de Valores entre Variáveis");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o valor para a variável A.
                Console.WriteLine("Digite o valor de A");
                A = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira o valor para a variável B.
                Console.WriteLine("Digite o valor de B");
                B = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Efetue a troca dos valores entre as variáveis A e B, de forma que
                //      A passe a possuir o valor de B e B passe a possuir o valor de A.
                //      Utilize uma variável temporária para realizar a troca.

                // 3. Saída de Dados:
                //    - Apresente os valores antes e após a efetivação do processo de troca.
                Console.WriteLine($"Valor de A {B}");
                Console.WriteLine($"Valor de B {A}");

            }
            static void Exercicio7()
            {
                // Passo a Passo:

                Console.WriteLine("Exercício 7: Adição e Multiplicação de Quatro Números Inteiros");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira quatro valores numéricos inteiros.

                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Realize as operações de adição e multiplicação dos quatro números entre si.
                int[] nums = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    while (true)
                    {
                        Console.Write($"Digite o {i + 1}º número inteiro: ");
                        string? entrada = Console.ReadLine();

                        if (int.TryParse(entrada, out int valor))
                        {
                            nums[i] = valor;
                            break;
                        }

                        Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                    }
                }

                var adicoes = new System.Collections.Generic.List<string>();
                var multiplicacoes = new System.Collections.Generic.List<string>();

                for (int i = 0; i < 4; i++)

                {
                    for (int j = i + 1; j < 4; j++)
                    {
                        int soma = nums[i] + nums[j];
                        int produto = nums[i] * nums[j];

                        adicoes.Add($"{nums[i]}+{nums[j]}={soma}");
                        multiplicacoes.Add($"{nums[i]}x{nums[j]}={produto}");
                    }
                }

                Console.WriteLine("Adições: " + string.Join(", ", adicoes));
                Console.WriteLine("Multiplicações: " + string.Join(", ", multiplicacoes));

                // 3. Saída de Dados:
                //    - Exiba as adições e multiplicacões dos quatro números.
            }
            static void Exercicio8()
            {
                double volume, comprimento, largura, altura;
                // Passo a Passo:

                Console.WriteLine("Exercício 8: Cálculo do Volume de uma Caixa Retangular");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o valor do comprimento da caixa retangular.
                Console.WriteLine("Digite o comprimento da caixa largura:");
                comprimento = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira o valor da largura da caixa retangular.
                Console.WriteLine("Digite a largura da caixa retangular: ");
                largura = Convert.ToDouble(Console.ReadLine());
                //    - Solicite ao usuário que insira o valor da altura da caixa retangular.
                Console.WriteLine("Digite a altura da caixa retangular: ");
                altura = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Utilize a fórmula para calcular o volume da caixa retangular: 
                //      volume = comprimento * largura * altura, onde
                //      comprimento, largura e altura são as dimensões da caixa.
                //    - Calcule o volume usando a fórmula mencionada.
                volume = comprimento * largura * altura;

                // 3. Saída de Dados:
                //    - Exiba o volume calculado da caixa retangular.
                Console.WriteLine($"O volume da caixa é de {volume}");
            }
            static void Exercicio9()
            {
                double num, quadrado;
                // Passo a Passo:
                Console.WriteLine("Exercício 9: Cálculo do Quadrado de um Número Inteiro");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor numérico inteiro.
                Console.WriteLine("Digite algum valor:");
                num = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o quadrado do número lido, multiplicando-o por ele mesmo.
                quadrado = num * num;
                // 3. Saída de Dados:
                //    - Exiba o valor do número elevado ao quadrado.
                Console.WriteLine($"{num} elevado é {quadrado}");
            }
            static void Exercicio10()
            {
                double A, B, dif;
                // Passo a Passo:

                Console.WriteLine("Exercício 10: Cálculo da Diferença entre Dois Números Inteiros");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira dois valores numéricos inteiros.
                Console.WriteLine("Digite primeiro valor:");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite segundo valor:");
                B = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule a diferença entre os dois números, subtraindo o segundo número
                //      do primeiro.
                dif = A - B;
                // 3. Saída de Dados:
                //    - Exiba a diferença entre os dois números.
                Console.WriteLine($"a diferença é de {dif}");

            }
            static void Exercicio11()
            {
                double dolar, real, cotacao;
                // Passo a Passo:

                Console.WriteLine("Exercício 11: Conversão de Dólar para Real");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor em dólar (US$).
                Console.WriteLine("Digite em dólar que quer converter:");
                dolar = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o valor equivalente em real (R$) multiplicando o valor em
                //      dólar pela cotação do dólar.
                cotacao = 5.60;
                real = dolar * cotacao;

                // 3. Saída de Dados:
                //    - Exiba o valor convertido em real.
                Console.WriteLine($" R${real} na cotacao de ${cotacao}");

            }
            static void Exercicio12()
            {
                double dolar, real, cotacao;
                // Passo a Passo:

                Console.WriteLine("Exercício 12: Conversão de Real para Dólar");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor em real (R$).
                Console.WriteLine("Digite em real para converter em dolar:");
                real = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o valor equivalente em dólar (US$) dividindo o valor em real
                //      pela cotação do dólar.
                cotacao = 5.60;
                dolar = real / cotacao;

                // 3. Saída de Dados:
                //    - Exiba o valor convertido em dólar.
                Console.WriteLine($" ${dolar}");

            }
            static void Exercicio13()
            {
                double A, B, C, quadrado;
                // Passo a Passo:

                Console.WriteLine("Exercício 13: Cálculo da Soma dos Quadrados de Três Números");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira três valores numéricos.
                Console.WriteLine("Digite primeiro valor:");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite segundo valor:");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite primeiro valor:");
                C = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o quadrado de cada um dos três números.
                //    - Some os quadrados calculados.
                quadrado = (A * A) + (B * B) + (C * C);
                // 3. Saída de Dados:
                //    - Exiba o resultado da soma dos quadrados.
                Console.WriteLine($"A soma dos quadrados é {quadrado}");

            }
            static void Exercicio14()
            {
                double A, B, C, quadrado, soma;
                // Passo a Passo:

                Console.WriteLine("Exercício 14: Cálculo do Quadrado da Soma de Três Números");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira três valores numéricos.
                Console.WriteLine("Digite primeiro valor:");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite segundo valor:");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite primeiro valor:");
                C = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule a soma dos três números.
                //    - Calcule o quadrado da soma.
                soma = A + B + C;
                quadrado = soma * soma;
                // 3. Saída de Dados:
                //    - Exiba o resultado do quadrado da soma.
                Console.WriteLine($"A soma dos quadrados é {quadrado}");


            }
            static void Exercicio15()
            {
                double num1, num2, num3, num4, produto, soma;
                // Passo a Passo:

                Console.WriteLine("Exercício 15: Cálculo do Produto e da Soma de Quatro Números");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira quatro valores numéricos.
                Console.WriteLine("Digite primeiro valor:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite segundo valor:");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite primeiro valor:");
                num3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite quarto valor:");
                num4 = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o produto do primeiro e do terceiro número.
                //    - Calcule a soma do segundo e do quarto número.
                produto = num1 + num2;
                soma = num3 + num4;


                // 3. Saída de Dados:
                //    - Exiba os resultados do produto e da soma.
                Console.WriteLine($"Produto {produto}, soma {soma}");

            }
            static void Exercicio16()
            {
                double aumento, salario, porcentagem, novo_salario;
                // Passo a Passo:
                Console.WriteLine(" Exercício 16: Cálculo do Novo Salário com Aumento");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o valor do salário mensal.
                //    - Solicite ao usuário que insira a porcentagem de aumento do salário.
                Console.WriteLine("Digite seu salario mensal:");
                salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a porcentagem do aumento que voce teve:");
                porcentagem = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o valor do aumento usando a fórmula: aumento = salario * (aumento_porcentagem / 100)
                //    - Calcule o novo salário somando o salário original ao aumento.
                aumento = salario * (porcentagem / 100);
                novo_salario = salario + aumento;

                // 3. Saída de Dados:
                //    - Exiba o valor do novo salário e o valor do aumento concedido.
                Console.WriteLine($"Novo salario é de R${novo_salario}, Aumento concedido {aumento}");

            }
            static void Exercicio17()
            {
                // Passo a Passo:
                double area, raio;
                Console.WriteLine("Exercício 17: Cálculo da Área de uma Circunferência");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o valor do raio da circunferência.
                Console.WriteLine("Digite o raio da circunferência: ");
                raio = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule a área da circunferência usando a fórmula: área = π * raio * raio.
                area = Math.PI * Math.Pow(raio, 2);
                // 3. Saída de Dados:
                //    - Exiba o valor da área calculada.
                Console.WriteLine($"A area calculada é {area}");

            }
            static void Exercicio18()
            {
                // Passo a Passo:

                Console.WriteLine("Exercício 18: Apuração de Votos em uma Eleição Sindical");


                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira a quantidade de votos válidos para cada  candidato.
                Console.WriteLine("Digite a quantidade de votos do Candidato 1: ");
                int candidato1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de votos do Candidato 2: ");
                int candidato2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de votos do Candidato 3: ");
                int candidato3 = int.Parse(Console.ReadLine());

                //    - Solicite ao usuário que insira a quantidade de votos nulos.
                Console.WriteLine("Digite a quantidade de votos nulos: ");
                int nulos = int.Parse(Console.ReadLine());
                //    - Solicite ao usuário que insira a quantidade de votos em branco.
                Console.WriteLine("Digite a quantidade de votos brancos");
                int brancos = int.Parse(Console.ReadLine());
                //    - Aguarde a entrada do usuário.


                // 2. Processamento:
                //    - Calcule o número total de eleitores somando os votos válidos, nulos e
                //      em branco.
                //    - Calcule o percentual de votos válidos para cada candidato e o total de
                //      votos nulos e em branco.
                int totalEleitores = candidato1 + candidato2 + candidato3 + nulos + brancos;

                double percCand1 = (double)candidato1 / totalEleitores * 100;
                double percCand2 = (double)candidato2 / totalEleitores * 100;
                double percCand3 = (double)candidato3 / totalEleitores * 100;
                double percNulos = (double)nulos / totalEleitores * 100;
                double percBranco = (double)brancos / totalEleitores * 100;

                // 3. Saída de Dados:
                //    - Exiba o número total de eleitores.
                //    - Exiba o percentual de votos válidos para cada candidato.
                //    - Exiba o percentual de votos nulos.
                //    - Exiba o percentual de votos em brancos
                Console.WriteLine("\n===== RESULTADO DA ELEIÇÃO =====");
                Console.WriteLine($"Total de eleitores: {totalEleitores}");

                Console.WriteLine("\nPercentual de votos:");
                Console.WriteLine($"Candidato 1: {percCand1:F2}%");
                Console.WriteLine($"Candidato 2: {percCand2:F2}%");
                Console.WriteLine($"Candidato 3: {percCand3:F2}%");
                Console.WriteLine($"Votos nulos: {percNulos:F2}%");
                Console.WriteLine($"Votos em branco: {percBranco:F2}%");

                Console.WriteLine("\nPressione qualquer tecla para sair...");
                Console.ReadKey();

            }
            static void Exercicio19()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 19: Cálculo das Quatro Operações Básicas");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira dois valores numéricos.
                Console.WriteLine("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule a adição dos dois valores.
                //    - Calcule a subtração do primeiro valor pelo segundo.
                //    - Calcule a multiplicação dos dois valores.
                //    - Calcule a divisão do primeiro valor pelo segundo.
                int adicao = num1 + num2;
                int subitracao = num1 - num2;
                int multiplicacao = num1 * num2;
                int divasao = num1 / num2;

                // 3. Saída de Dados:
                //  - Exiba os resultados das quatro operações.
                Console.WriteLine($"Adição {adicao}");
                Console.WriteLine($"Subtração {subitracao}");
                Console.WriteLine($"Multiplicação {multiplicacao}");
                Console.WriteLine($"Divisão {divasao}");


            }
            static void Exercicio20()
            {
                double velocidade, distancia, tempo;
                // Passo a Passo:

                Console.WriteLine("Exercício 20: Cálculo da Velocidade de um Projétil");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira a distância percorrida em quilômetros e o tempo em horas.
                //    - Aguarde a entrada do usuário.
                Console.WriteLine("Digite a distância percorrida em quilômetros:");
                distancia = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o tempo em horas: ");
                tempo = Convert.ToDouble(Console.ReadLine());

                // 2. Processamento:
                //    - Calcule a velocidade do projétil em metros por segundo usando a fórmula: velocidade = distância / tempo / 3.6.
                velocidade = distancia / tempo / 3.6;
                Console.WriteLine($"A velocidade = {velocidade:F2} m/s");

                // 3. Saída de Dados:
                //    - Exiba o valor da velocidade em metros por segundo.
            }
            static void Exercicio21()
            {
                // Passo a Passo:
                double bas, expoente, potencia;
                Console.WriteLine("Exercício 21: Cálculo de Potência");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira dois valores numéricos inteiros representando a base e o expoente da potência.
                Console.WriteLine("Digite o valor da base:");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor do expoente: ");
                expoente = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule a potência utilizando a base e o expoente fornecidos.
                potencia = Math.Pow(bas, expoente);

                // 3. Saída de Dados:
                //    - Exiba o resultado da potência calculada.
                Console.WriteLine($"A potência é {potencia}");
            }
            static void Exercicio22()
            {
                double volume, raio;
                Console.WriteLine("Exercício 22: Cálculo do Volume de uma Esfera ");
                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o raio da esfera.
                Console.WriteLine("Digite o raio da esfera: ");
                raio = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o volume da esfera utilizando a fórmula: volume = (4/3) * π * raio³.
                volume = (4 / 3) * Math.PI * Math.Pow(raio, 3);

                // 3. Saída de Dados:
                //    - Exiba o valor do volume da esfera.
                Console.WriteLine($"O volume da esfera é {volume:F2}");

            }
            static void Exercicio23()
            {
                double pes, metros;
                // Passo a Passo:
                Console.WriteLine("Exercício 23: Conversão de Pés para Metros");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira uma medida em pés.
                Console.WriteLine("Digite a medida em pés: ");
                pes = Convert.ToDouble(Console.ReadLine());
                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Converta a medida de pés para metros usando a fórmula: metros = pés * 0.3048.
                metros = pes * 0.3048;

                // 3. Saída de Dados:
                //    - Exiba a medida equivalente em metros.
                Console.WriteLine($"A medida equivalente a {metros} metros");
            }
            static void Exercicio24()
            {
                double bas, indice, raiz;
                // Passo a Passo:
                Console.WriteLine("Exercicio 24: Cálculo de Raiz ");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira a base e o índice da raiz.
                //    - Aguarde a entrada do usuário.
                Console.WriteLine("Digite o valor da base: ");
                bas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o valor do índice da raiz: ");
                indice = Convert.ToDouble(Console.ReadLine());

                // 2. Processamento:
                //    - Calcule a raiz de base qualquer com índice qualquer.
                raiz = Math.Pow(bas, (1 / indice));

                // 3. Saída de Dados:
                //    - Exiba o valor da raiz calculada.
                Console.WriteLine($"O valor da raiz é {raiz:F2}");
            }
            static void Exercicio25()
            {

                // Passo a Passo:
                Console.WriteLine("Exercício 25: Sucessor e Antecessor de um Número Inteiro");

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor numérico inteiro.
                Console.WriteLine("Digite um valor: ");
                int num = Convert.ToInt32(Console.ReadLine());

                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule o sucessor e o antecessor do número.
                int antecessor = num - 1;
                int sucessor = num + 1;

                // 3. Saída de Dados:
                //    - Exiba o valor do sucessor e do antecessor.
                Console.WriteLine($"O valor {num} o seu antecessor é {antecessor} e seu sucessor é {sucessor}");

            }
            static void Exercicio26()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 26: Cálculo do Quadrado da Divisão de Dois Números Inteiros");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira dois valores numéricos inteiros.
                Console.WriteLine("Digite primeiro valor: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite segundo valor: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                //    - Aguarde a entrada do usuário.

                // 2. Processamento:
                //    - Calcule a divisão do primeiro número pelo segundo número.
                //    - Calcule o quadrado do resultado da divisão.
                int divisao = num1 / num2;
                int quadrado = divisao * divisao;

                // 3. Saída de Dados:
                //    - Apresente o resultado inteiro do quadrado da divisão.
                Console.WriteLine($"O quadrado da divisão é {quadrado}");
            }
            static void Exercicio27()
            {
                Console.WriteLine("Exercício 27: Cálculo da Diferença entre Dois Números Inteiros");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira dois valores numéricos inteiros.
                //    - Aguarde a entrada do usuário.
                int num1, num2, diferenca;
                Console.WriteLine("Digite o primeiro número: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                // 2. Processamento:
                //    - Identifique o maior e o menor valor entre os dois números.
                //    - Calcule a diferença entre o maior e o menor valor.
                if (num1 > num2)
                {
                    diferenca = num1 - num2;
                }
                else
                {
                    diferenca = num2 - num1;
                }
                // 3. Saída de Dados:
                //    - Apresente o resultado da diferença entre o maior e o menor valor
                Console.WriteLine($"A diferença entre {num1} e {num2} é: {diferenca}");
            }
            static void Exercicio28()
            {

                // Passo a Passo:
                Console.WriteLine("Exercício 28: Classificação de Número Positivo ou Negativo");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor numérico inteiro.
                //    - Aguarde a entrada do usuário.
                Console.WriteLine("Digite o Valor: ");
                int num = Convert.ToInt32(Console.ReadLine());

                // 2. Processamento:
                //    - Verifique se o número é positivo, negativo ou neutro (zero).

                if (0 < num)
                {
                    Console.WriteLine($"O número {num} é Positivo");
                }
                else
                {
                    Console.WriteLine($"O número {num} é Negativo");
                }

                // 3. Saída de Dados:
                //    - Apresente a classificação do número como positivo, negativo ou neutro (zero).

            }
            static void Exercicio29()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 29: Cálculo da Média e Verificação de Aprovação");

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira os valores das quatro notas bimestrais
                //      do aluno.
                //    - Aguarde a entrada do usuário.
                int nota1, nota2, nota3, nota4, media;
                Console.WriteLine("Digite a primeira Nota: ");
                nota1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a segunda Nota: ");
                nota2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a terceira Nota: ");
                nota3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quarta Nota: ");
                nota4 = Convert.ToInt32(Console.ReadLine());


                // 2. Processamento:
                //    - Calcule a média aritmética das quatro notas.
                //    - Verifique se a média é maior ou igual a 5 para determinar se o aluno
                //      foi aprovado ou reprovado.
                media = (nota1 + nota2 + nota3 + nota4) / 4;

                // 3. Saída de Dados:
                //    - Apresente a média calculada e a informação se o aluno foi aprovado ou
                //      reprovado.
                if (media >= 5)
                {
                    Console.WriteLine($"Média: {media} Aprovado");
                }
                else
                {
                    Console.WriteLine($"Média: {media} Negativa");
                }

            }
            static void Exercicio30()
            {
                Console.WriteLine("Exercício 30: Cálculo da Média e Verificação de Aprovação com Exame");

                // Passo a Passo:
                double nota1, nota2, nota3, nota4, media;
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira os valores das quatro notas bimestrais
                //      do aluno.
                //    - Aguarde a entrada do usuário.
                Console.WriteLine("Digite a primeira Nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segunda Nota: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceira Nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quarta Nota: ");
                nota4 = Convert.ToDouble(Console.ReadLine());

                // 2. Processamento:
                //    - Calcule a média aritmética das quatro notas.
                //    - Verifique se a média é maior que 7. Se sim, o aluno está aprovado.
                //    - Caso contrário, solicite a nota do exame e calcule a nova média.
                //    - Verifique se a nova média é maior que 5 para determinar se o aluno foi
                //      aprovado em exame.
                media = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine($"\nMédia: {media:F2}");
                if (media >= 7)
                {
                    Console.WriteLine("Aluno aprovado!");
                }
                else
                {
                    Console.WriteLine("Aluno em exame.");

                    // Entrada da nota do exame
                    Console.Write("Digite a nota do exame: ");
                    double exame = Convert.ToDouble(Console.ReadLine());

                    // Nova média
                    double novaMedia = (media + exame) / 2;

                    Console.WriteLine($"Nova média: {novaMedia:F2}");

                    if (novaMedia >= 5)
                    {
                        Console.WriteLine("Aluno aprovado em exame!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno reprovado.");
                    }
                }

                // 3. Saída de Dados:
                //    - Apresente a média calculada e a situação do aluno (aprovado, exame ou
                //      reprovado).


            }
            static void Exercicio31()
            {
                Console.WriteLine("Exercício 31: Resolução de Equação de Segundo Grau");

                // Passo a Passo:
                double a, b, c, delta, x1, x2;

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira os valores dos coeficientes "a", "b" e "c".
                //    - Aguarde a entrada do usuário.
                Console.WriteLine("Digite a primeiro Valor : ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a segundo Valor: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a terceiro Valor: ");
                c = Convert.ToDouble(Console.ReadLine());


                // 2. Processamento:
                //    - Calcule as raízes da equação de segundo grau utilizando a fórmula de
                //      Bhaskara: x = (-b ± √(b² - 4ac)) / 2a.
                if (a == 0)
                {
                    Console.WriteLine("O valor de 'a' deve ser diferente de zero.");
                }
                else
                {
                    delta = Math.Pow(b, 2) - (4 * a * c);

                    if (delta >= 0)
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                        Console.WriteLine($"\nx1 = {x1}");
                        Console.WriteLine($"x2 = {x2}");
                    }
                    else
                    {
                        Console.WriteLine("Não existem raízes reais.");
                    }
                }

                // 3. Saída de Dados:
                //    - Exiba as raízes da equação.




            }
            static void Exercicio32()
            {
                Console.WriteLine("Exercício 32: Ordenação de Três Números Inteiros");
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira três valores inteiros.
                //    - Aguarde a entrada do usuário.
                int num1, num2, num3, temp;

                Console.Write("Digite o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                num3 = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Compare os valores e os organize em ordem crescente.
                //    - Se o primeiro valor for maior que o segundo, troque-os.
                //    - Se o primeiro valor for maior que o terceiro, troque-os.
                //    - Se o segundo valor for maior que o terceiro, troque-os.
                // Ordenação
                if (num1 > num2)
                {
                    temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                if (num1 > num3)
                {
                    temp = num1;
                    num1 = num3;
                    num3 = temp;
                }

                if (num2 > num3)
                {
                    temp = num2;
                    num2 = num3;
                    num3 = temp;
                }

                // 3. Saída de Dados:
                //    - Apresente os valores ordenados em ordem crescente.
                Console.WriteLine("\nNúmeros em ordem crescente:");
                Console.WriteLine($"{num1}, {num2}, {num3}");


            }
            static void Exercicio33()
            {
                Console.WriteLine("Exercício 33: Valores Divisíveis por 2 e 3");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira quatro valores numéricos inteiros.
                //    - Aguarde a entrada do usuário.
                int num1, num2, num3, num4;

                Console.Write("Digite o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                num3 = int.Parse(Console.ReadLine());

                Console.Write("Digite o quarto número: ");
                num4 = int.Parse(Console.ReadLine());

                // 2. Processamento:
                //    - Verifique se cada valor é divisível por 2 e 3.
                //    - Se um valor for divisível por 2 e 3, apresente-o.
                Console.WriteLine("\nValores divisíveis por 2 e 3:");
                if (num1 % 2 == 0 && num1 % 3 == 0)
                    Console.WriteLine(num1);
                if (num2 % 2 == 0 && num2 % 3 == 0)
                    Console.WriteLine(num2);
                if (num3 % 2 == 0 && num3 % 3 == 0)
                    Console.WriteLine(num3);
                if (num4 % 2 == 0 && num4 % 3 == 0)
                    Console.WriteLine(num4);


                // 3. Saída de Dados:
                //    - Apresente os valores divisíveis por 2 e 3.

            }
            static void Exercicio34()
            {
                Console.WriteLine(" Exercício 34: Valores Divisíveis por 2 ou 3");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira quatro valores numéricos inteiros.
                //    - Aguarde a entrada do usuário.
                int num1, num2, num3, num4;

                Console.Write("Digite o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                num3 = int.Parse(Console.ReadLine());

                Console.Write("Digite o quarto número: ");
                num4 = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Verifique se cada valor é divisível por 2 ou por 3.
                //    - Se um valor for divisível por 2 ou 3, apresente-o.
                Console.WriteLine("\nValores divisíveis por 2 e 3:");
                if (num1 % 2 == 0 && num1 % 3 == 0)
                    Console.WriteLine(num1);
                if (num2 % 2 == 0 && num2 % 3 == 0)
                    Console.WriteLine(num2);
                if (num3 % 2 == 0 && num3 % 3 == 0)
                    Console.WriteLine(num3);
                if (num4 % 2 == 0 && num4 % 3 == 0)
                    Console.WriteLine(num4);

                // 3. Saída de Dados:
                //    - Apresente os valores divisíveis por 2 ou 3.





            }
            static void Exercicio35()
            {
                Console.WriteLine("Exercício 35: Maior e Menor Valor");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira cinco valores numéricos inteiros.
                //    - Aguarde a entrada do usuário.
                int num1, num2, num3, num4, num5;
                int maior, menor;

                Console.Write("Digite o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                num3 = int.Parse(Console.ReadLine());

                Console.Write("Digite o quarto número: ");
                num4 = int.Parse(Console.ReadLine());

                Console.Write("Digite o quinto número: ");
                num5 = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Encontre o maior e o menor valor dentre os cinco valores fornecidos.
                maior = num1;
                menor = num1;


                if (num2 > maior)
                {
                    maior = num2;
                }
                if (num2 < menor)
                {
                    menor = num2;
                }

                if (num3 > maior)
                {
                    maior = num3;
                }
                if (num3 < menor)
                {
                    menor = num3;
                }

                if (num4 > maior)
                {
                    maior = num4;
                }
                if (num4 < menor)
                {
                    menor = num4;
                }

                if (num5 > maior)
                {
                    maior = num5;
                }
                if (num5 < menor)
                {
                    menor = num5;
                }
                // 3. Saída de Dados:
                //    - Apresente o maior e o menor valor encontrados.
                Console.WriteLine($"Maior valor {maior}");
                Console.WriteLine($"Menor valor {menor}");

            }
            static void Exercicio36()
            {
                Console.WriteLine("Exercício 36: Par ou Ímpar");

                // Passo a Passo:
                int num;
                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um número inteiro.
                Console.WriteLine("Digite um valor: ");
                num = int.Parse(Console.ReadLine());
                //    - Aguarde a entrada do usuário.


                // 2. Processamento:
                //    - Verifique se o número fornecido é par ou ímpar.
                if (num % 2 == 0)
                {
                    Console.WriteLine("Par");
                }
                else
                {
                    Console.WriteLine("Ímpar");
                }

                // 3. Saída de Dados:
                //    - Apresente se o número é par ou ímpar.



            }
            static void Exercicio37()
            {
                Console.WriteLine("Exercício 37: Verificação de Faixa de Valor");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor numérico inteiro.
                //    - Aguarde a entrada do usuário.
                int num;
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Verifique se o valor está na faixa de 1 até 9.
                if (num >= 1 && num <= 9)
                {
                    Console.WriteLine("Valor está na faixa permitida.");
                }
                else
                {
                    Console.WriteLine("Valor não está na faixa permitida.");
                }

                // 3. Saída de Dados:
                //    - Apresente se o valor está na faixa permitida ou não.

            }
            static void Exercicio38()
            {
                Console.WriteLine("Exercício 38: Verificação de Valor Menor ou Igual a 3");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um valor inteiro.
                //    - Aguarde a entrada do usuário.
                int valor;
                Console.WriteLine("Digite o valor Inteiro: ");
                valor = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Verifique se o valor inserido é menor ou igual a 3.
                if (valor <= 3)
                {
                    Console.WriteLine($"Valor {valor}");
                }

                // 3. Saída de Dados:
                //    - Apresente o valor inserido se ele for menor ou igual a 3.




            }
            static void Exercicio39()
            {
                Console.WriteLine("Exercício 39: Múltiplo de 3 e 5");

                // Passo a Passo:

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um número.
                //    - Aguarde a entrada do usuário.
                int valor;
                Console.WriteLine("Digite o valor Inteiro: ");
                valor = int.Parse(Console.ReadLine());

                // 2. Processamento:
                //    - Verifique se o número inserido é um múltiplo de 3 e 5.
                //    - Para verificar se um número é múltiplo de outro, podemos usar o operador de módulo (%).
                //      Se o resultado da divisão do número pelo múltiplo desejado for igual a zero, então o número é múltiplo.
                //      Ou seja, se numero % 3 == 0 e numero % 5 == 0, então o número é múltiplo de 3 e 5.
                // 3. Saída de Dados:
                //    - Apresente o número inserido se ele for um múltiplo de 3 e 5.
                if (valor % 3 == 0 && valor % 5 == 0)
                {
                    Console.WriteLine($"valor {valor} é multiplo 3 e de 5");
                }
               

            }
            static void Exercicio40()
            {

                // Passo a Passo:
                Console.WriteLine("Exercício 40: Soma e Verificação");

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira três valores desconhecidos.
                //    - Aguarde a entrada do usuário.
                int valor1, valor2, valor3, soma;
                Console.WriteLine("Digite o primeiro valor Inteiro: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor Inteiro: ");
                valor2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o terceiro valor Inteiro: ");
                valor3 = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Some os três valores inseridos.
                // 3. Verificação:
                //    - Verifique se a soma dos três valores é maior que 100.
                //    - Se a soma for maior que 100, apresente o resultado.

                // 4. Saída de Dados:
                //    - Apresente o resultado da soma apenas se ela for maior que 100.
                soma = valor1 + valor2 + valor3;
                if (soma > 100)
                {
                    Console.WriteLine(soma);
                }





            }
            static void Exercicio41()
            {


                // Passo a Passo:
                Console.WriteLine("Exercício 41: Multiplicação e Verificação");

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira um número inteiro.
                //    - Aguarde a entrada do usuário.
                int num, resultado;
                Console.WriteLine("Digite um valor Inteiro: ");
                num = int.Parse(Console.ReadLine());


                // 2. Processamento:
                //    - Multiplique o número inserido por dois.
                resultado = num * 2;



                // 3. Verificação:
                //    - Verifique se o resultado da multiplicação é maior que 30.
                //    - Se o resultado for maior que 30, apresente-o.
                if (resultado > 30)
                {
                    Console.WriteLine(resultado);
                }

                // 4. Saída de Dados:
                //    - Apresente o resultado da multiplicação apenas se ele for maior que 30.

            }
            static void Exercicio42()
            {
                Console.WriteLine("Exercício 42: Quadrados na Faixa de Valores");

                // Passo a Passo:

                // 1. Inicialização:
                //    - Inicialize uma variável para armazenar o resultado dos quadrados.


                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que percorre os números inteiros de 15 a 200.
                //    - Para cada número inteiro na faixa especificada, calcule o seu quadrado e armazene o resultado.

                // 3. Saída de Dados:
                //    - Apresente os quadrados dos números inteiros na faixa de valores de 15 a 200.

                int quadrado;

                for (int numero = 15; numero <= 200; numero++)
                {
                    quadrado = numero * numero;
                    Console.WriteLine($"{numero}² = {quadrado}");
                }





            }
            static void Exercicio43()
            {

                // Passo a Passo:
                Console.WriteLine("Exercício 43: Tabuada de um Número");

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira o número para o qual a tabuada será gerada.
                //    - Aguarde a entrada do usuário.
                int num, mult, prod;
                Console.WriteLine("Insira o número que será feito uma tabuada");
                num = int.Parse(Console.ReadLine());

                // 2. Inicialização:
                //    - Inicialize o multiplicador como 1.
                mult = 1;
                while (mult <= 10)
                {
                    prod = num * mult;
                    Console.WriteLine($"{num} x {mult} = {prod}");
                    mult++;
                }

                // 3. Enquanto o multiplicador for menor ou igual a 10:
                //    - Calcule o produto do número fornecido pelo multiplicador.
                //    - Apresente o resultado da multiplicação na forma "número x multiplicador = produto".
                //    - Incremente o multiplicador.


            }
            static void Exercicio44()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 44: Soma dos Cem Primeiros Números Naturais");
                // 1. Inicialização da Soma:
                //    - Inicialize uma variável "soma" com valor zero para armazenar a soma dos números.
                int soma, contador;

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que percorre os números de 1 a 100.
                //    - Para cada número, adicione-o à variável "soma".
                soma = 0;
                contador = 1;
                while (contador <= 100)
                {
                    soma = soma + contador;
                    contador = contador + 1;
                }
                Console.WriteLine($"{soma}");


                // 3. Saída de Dados:
                //    - Apresente o valor da variável "soma" como resultado da soma dos cem primeiros números naturais.
            }
            static void Exercicio45()
            {

                // Passo a Passo:
                Console.WriteLine("Exercício 45: Somatório dos Valores Pares");
                // 1. Inicialização da Soma:
                //    - Inicialize uma variável "somaPares" com valor zero para armazenar o somatório dos valores pares.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que percorre os números de 2 a 500 com incremento de 2.
                //    - Para cada número par, adicione-o à variável "somaPares".

                // 3. Saída de Dados:
                //    - Apresente o valor da variável "somaPares" como resultado do somatório dos valores pares na faixa de 1 até 500.
                int somapares, numero;
                somapares = 0;

                for (numero = 2; numero <= 500; numero += 2)
                {
                    somapares = somapares + numero;
                }
                Console.WriteLine("A soma dos números pares de 1 até 500 é: " + somapares);


            }
            static void Exercicio46()
            {
                Console.WriteLine("Exercício 46: Números Ímpares na Faixa de Valores");

                // Passo a Passo:

                // 1. Inicialização:
                //    - Inicialize uma variável "numero" com valor 1.

                // 2. Laço de Iteração:
                //    - Enquanto "numero" for menor ou igual a 199, faça:
                //        - Exiba o valor de "numero".
                //        - Incremente o valor de "numero" em 2.
                int num = 1;
                while (num <= 199)
                {
                    Console.WriteLine(num);
                    num = num + 2;
                }

            }
            static void Exercicio47()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 47: Valores Divisíveis por 4 Menores que 200");

                // 1. Laço de Iteração:
                //    - Inicie um laço de iteração que percorre os números de 4 até 196 com incremento de 4 (apenas números divisíveis por 4).
                //    - Para cada número divisível por 4, exiba-o.
                for (int numero = 4; numero <= 196; numero += 4)
                {
                    Console.WriteLine(numero);
                }
            }
            static void Exercicio48()
            {
                Console.WriteLine("Exercício 48: Potências de 3");

                // Passo a Passo:

                // 1. Inicialização do Contador de Expoentes:
                //    - Inicialize o contador de expoentes "expoente" com 0.

                // 2. Laço de Iteração com Condição de Parada:
                //    - Enquanto o contador de expoentes "expoente" for menor ou igual a 15, faça:
                //        - Calcule o valor da potência de 3 elevado ao expoente e exiba-o.
                //        - Incremente o contador de expoentes "expoente" em 1.
                int expoente = 0;
                while (expoente <= 15)
                {
                    double potencia = Math.Pow(3, expoente);
                    Console.WriteLine("3^" + expoente + " = " + potencia);
                    expoente = expoente + 1;
                }


            }
            static void Exercicio49()
            {
                Console.WriteLine("Exercício 49: Potência de uma Base Elevada a um Expoente");


                // Passo a Passo:

                // 1. Inicialização da Potência:
                //    - Inicialize a variável "potencia" com o valor da base.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração usando o comando FOR que percorre o intervalo de 1 até o expoente.
                //    - Dentro do laço, multiplique a variável "potencia" pela base.

                // 3. Saída de Dados:
                //    - Exiba o resultado da potência.

                Console.Write("Digite a base: ");
                int baseNumero = int.Parse(Console.ReadLine());

                Console.Write("Digite o expoente: ");
                int expoente = int.Parse(Console.ReadLine());

                int potencia = baseNumero;

                for (int i = 1; i < expoente; i++)
                {
                    potencia = potencia * baseNumero;
                }

                Console.WriteLine(baseNumero + " elevado a " + expoente + " = " + potencia);




            }
            static void Exercicio50()
            {
                Console.WriteLine("Exercício 50: Sequência de Fibonacci");

                // Passo a Passo:

                // 1. Inicialização dos Termos:
                //    - Defina os dois primeiros termos da sequência como 0 e 1.

                // 2. Geração dos Termos:
                //    - Utilize um loop enquanto para gerar os próximos termos da sequência de Fibonacci.
                //    - Cada termo subsequente é a soma dos dois termos anteriores.
                //    - Continue gerando termos até alcançar o décimo quinto termo.

                // 3. Saída de Dados:
                //    - Exiba os valores dos termos da sequência até o décimo quinto termo.
                int termo1 = 0;
                int termo2 = 1;
                Console.WriteLine(termo1);
                Console.WriteLine(termo2);
                int i = 3;
                while (i <= 15)
                {
                    int proximo_termo = termo1 + termo2;
                    Console.WriteLine(proximo_termo);
                    termo1 = termo2;
                    termo2 = proximo_termo;
                    i = i + 1;
                }





            }
            static void Exercicio51()
            {
                Console.WriteLine("Exercício 51: Conversão de Graus Celsius em Fahrenheit");

                // 1. Laço de Iteração:
                //    - Inicie um laço de iteração usando o comando FOR que percorre o intervalo de 10°C a 100°C, de dez em dez graus.
                //    - Dentro do laço, calcule o valor equivalente em Fahrenheit usando a fórmula de conversão.

                // 2. Saída de Dados:
                //    - Exiba os valores de conversão em Celsius e Fahrenheit.
                for (int grauCelsius = 10; grauCelsius <= 100; grauCelsius += 10)
                {
                    double grauFahrenheit = (grauCelsius * 9.0 / 5.0) + 32;

                    Console.WriteLine(grauCelsius + "°C = " + grauFahrenheit + "°F");
                }
            }
            static void Exercicio52()
            {
                Console.WriteLine("Exercício 52: Somatório de Grãos de Trigo no Tabuleiro de Xadrez");

                // 1. Inicialização do Somatório:
                //    - Inicialize uma variável "totalGrãos" com valor zero para armazenar o somatório.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração usando o comando WHILE que continua enquanto o número do quadro é menor ou igual a 64.
                //    - Para cada quadro, calcule o número de grãos de trigo usando a fórmula: 2 elevado ao número do quadro menos 1.

                // 3. Atualização do Somatório:
                //    - Adicione o número de grãos de trigo calculado à variável "totalGrãos" a cada iteração.

                // 4. Saída de Dados:
                //    - Apresente o valor do somatório total de grãos de trigo no tabuleiro de xadrez.
                double totalgraos = 0;
                int quadro = 1;
                while (quadro <= 64)
                {
                    double graosnoquadrado = Math.Pow(2, quadro - 1);
                    totalgraos = totalgraos + graosnoquadrado;
                    quadro = quadro + 1;
                }
                Console.WriteLine("Total de grãos de trigo no tabuleiro de xadrez = " + totalgraos);
            }
            static void Exercicio53()
            {
                Console.WriteLine("Exercício 53: Somatório da Fatorial de Quinze Valores");

                // Passo a Passo:

                // 1. Inicialização do Somatório:
                //    - Inicialize uma variável "somatorio" com valor zero para armazenar o somatório.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que percorre quinze vezes, representando os quinze valores a serem lidos.
                //    - Para cada valor lido, calcule sua fatorial.

                // 3. Cálculo da Fatorial:
                //    - Para calcular a fatorial de um número, inicie uma variável "fatorial" com valor 1.
                //    - Utilize um segundo laço de iteração para multiplicar "fatorial" por cada número inteiro no intervalo de 1 até o número lido.

                // 4. Atualização do Somatório:
                //    - Adicione o valor da fatorial calculada à variável "somatorio" a cada iteração.

                // 5. Saída de Dados:
                //    - Apresente o valor do somatório total da fatorial dos quinze valores lidos.
                long somatorio = 0;
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine("Digite um valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    long fatorial = 1;

                    for (int numero = 1; numero <= valor; numero++)
                    {
                        fatorial = fatorial * numero;
                    }
                    somatorio = somatorio + fatorial;
                }
                Console.WriteLine("Somatório da fatorial de cada valor lido: " + somatorio);

            }
            static void Exercicio54()
            {
                Console.WriteLine("Exercício 54: Somatório e Média de Dez Valores");

                // 1. Inicialização do Somatório e Contador:
                //    - Inicialize uma variável "somatorio" com valor zero para armazenar o somatório.
                //    - Inicialize uma variável "contador" com valor zero para contar o número de valores lidos.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que continua enquanto o "contador" for menor que dez.
                //    - Dentro do laço, solicite ao usuário que insira um valor numérico real.
                //    - Adicione o valor lido ao somatório.
                //    - Incremente o contador.

                // 3. Cálculo da Média:
                //    - Calcule a média dos valores lidos dividindo o somatório pelo número total de valores (neste caso, dez).

                // 4. Saída de Dados:
                //    - Apresente o somatório e a média dos valores lidos.
                double somatorio = 0;
                int contador = 0;

                while (contador < 10)
                {
                    Console.Write("Digite um valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    somatorio = somatorio + valor;
                    contador = contador + 1;


                }
                double media = somatorio / 10;

                Console.WriteLine("Somatório: " + somatorio);
                Console.WriteLine("Média: " + media);
            }
            static void Exercicio55()
            {
                Console.WriteLine("Exercício 55: Somatório, Média e Total de Valores Lidos");
                // 1. Inicialização do Somatório, Total de Valores Lidos e Média:
                //    - Inicialize uma variável "somatorio" com valor zero para armazenar o somatório.
                //    - Inicialize uma variável "totalValores" com valor zero para contar o total de valores lidos.
                //    - Inicialize uma variável "media" com valor zero para calcular a média.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que continua enquanto o valor lido for positivo.
                //    - Dentro do laço, solicite ao usuário que insira um valor numérico.
                //    - Se o valor lido for positivo, adicione-o ao somatório e incremente o total de valores lidos.
                //    - Atualize a média.

                // 3. Cálculo da Média:
                //    - Calcule a média dos valores lidos dividindo o somatório pelo total de valores lidos.

                // 4. Saída de Dados:
                //    - Apresente o somatório, a média e o total de valores lidos.
                double somatorio = 0;
                int totalValores = 0;
                double media = 0;

                while (true)
                {
                    Console.Write("Digite um valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    if (valor <= 0)
                    {
                        break;
                    }

                    somatorio = somatorio + valor;
                    totalValores = totalValores + 1;
                    media = somatorio / totalValores;
                }

                Console.WriteLine("Somatório: " + somatorio);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("Total de valores lidos: " + totalValores);



            }
            static void Exercicio56()
            {
                Console.WriteLine("Exercício 56: Fatorial dos Valores Ímpares entre 1 e 100");
                // 1. Inicialização do Resultado da Fatorial:
                //    - Inicialize uma variável "resultado" com o valor 1 para armazenar o resultado da fatorial.

                // 2. Laço de Iteração:
                //    - Inicie um laço de iteração que percorre os valores ímpares de 1 a 100 com incremento de 2.
                //    - Para cada valor ímpar, calcule a fatorial e atualize o resultado.

                // 3. Cálculo da Fatorial:
                //    - Calcule a fatorial de um número multiplicando-o por todos os números inteiros positivos menores ou iguais a ele.

                // 4. Saída de Dados:
                //    - Apresente o resultado da fatorial dos valores ímpares entre 1 e 100. 
                BigInteger resultado = 1;

                for (int numero = 1; numero <= 99; numero += 2)
                {
                    BigInteger fatorial = 1;

                    for (int valor = 1; valor <= numero; valor++)
                    {
                        fatorial = fatorial * valor;
                    }

                    resultado = resultado * fatorial;
                }

                Console.WriteLine("Resultado da fatorial dos valores ímpares de 1 a 100: " + resultado);


            }
            static void Exercicio57()
            {
                Console.WriteLine("Exercício 57: Cálculo da Área Total de uma Residência");
                // 1. Inicialização da Área Total:
                //    - Inicialize uma variável "areaTotal" com valor zero para armazenar a área total acumulada da residência.

                // 2. Laço de Iteração para Leitura de Cômodos:
                //    - Inicie um laço de iteração que permite ao usuário fornecer os dados de cada cômodo da residência.
                //    - Para cada cômodo, solicite ao usuário o nome, a largura e o comprimento.
                //    - Calcule a área do cômodo e acumule na variável "areaTotal".
                //    - Pergunte ao usuário se deseja continuar adicionando cômodos.
                //    - Se a resposta for "NÃO", encerre o laço.

                // 3. Saída de Dados:
                //    - Apresente a mensagem com o valor total acumulado da área residencial.
                double areaTotal = 0;
                string continuar;

                do
                {
                    Console.Write("Digite o nome do cômodo: ");
                    string nomeDoComodo = Console.ReadLine();

                    Console.Write("Digite a largura do cômodo (metros): ");
                    double larguraDoComodo = double.Parse(Console.ReadLine());

                    Console.Write("Digite o comprimento do cômodo (metros): ");
                    double comprimentoDoComodo = double.Parse(Console.ReadLine());

                    double areaDoComodo = larguraDoComodo * comprimentoDoComodo;

                    areaTotal = areaTotal + areaDoComodo;

                    Console.WriteLine("Área do " + nomeDoComodo + ": " + areaDoComodo + " m²");

                    Console.Write("Deseja adicionar outro cômodo? (SIM/NAO): ");
                    continuar = Console.ReadLine().ToUpper();

                    Console.WriteLine();

                } while (continuar == "SIM");

                Console.WriteLine("Área total da residência: " + areaTotal + " metros quadrados");



            }
            static void Exercicio58()
            {
                Console.WriteLine("Exercício 58: Maior e Menor Valores entre Valores Positivos");
                // 1. Inicialização dos Valores:
                //    - Inicialize as variáveis "maior" e "menor" com valores negativos, garantindo que o
                // primeiro valor positivo informado seja considerado como maior e menor.

                // 2. Laço de Leitura dos Valores:
                //    - Inicie um laço de leitura que solicita ao usuário informar um valor.
                //    - Verifique se o valor é positivo:
                //      - Se for negativo, encerre o laço.
                //      - Se for positivo, compare-o com os valores atuais de "maior" e "menor" e atualize
                // essas variáveis, se necessário.

                // 3. Saída de Dados:
                //    - Apresente o maior e o menor valores informados pelo usuário.
                int maior = -1;
                int menor = -1;

                while (true)
                {
                    Console.Write("Digite um valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    if (valor < 0)
                    {
                        break;
                    }

                    if (maior < valor)
                    {
                        maior = valor;
                    }

                    if (menor == -1 || menor > valor)
                    {
                        menor = valor;
                    }
                }

                Console.WriteLine("Maior valor: " + maior);
                Console.WriteLine("Menor valor: " + menor);

            }
            static void Exercicio59()
            {

                Console.WriteLine("Exercício 59: Divisão Inteira Sem Usar o Operador de Divisão");

                // 1. Entrada de Dados:
                //    - Solicite ao usuário que insira os dois números para divisão.
                //    - Aguarde a entrada do usuário.

                // 2. Cálculo da Divisão Inteira:
                //    - Inicialize uma variável "resultado" com 0 para armazenar o resultado da divisão inteira.
                //    - Inicialize uma variável "dividendo" com o primeiro número informado pelo usuário.
                //    - Inicialize uma variável "divisor" com o segundo número informado pelo usuário.
                //    - Enquanto o "dividendo" for maior ou igual ao "divisor", subtraia o "divisor" do "dividendo" e incremente o "resultado" em 1.

                // 3. Saída de Dados:
                //    - Apresente o resultado da divisão inteira.

                Console.Write("Digite o dividendo: ");
                int dividendo = int.Parse(Console.ReadLine());

                Console.Write("Digite o divisor: ");
                int divisor = int.Parse(Console.ReadLine());

                int resultado = 0;

                while (dividendo >= divisor)
                {
                    dividendo = dividendo - divisor;
                    resultado = resultado + 1;
                }

                Console.WriteLine("Resultado da divisão: " + resultado);
            }
            static void Exercicio60()
            {
                Console.WriteLine("Exercício 60: Quadrados dos Valores Inteiros de 15 a 200 Contando de 3 em 3");

                // 1. Inicialização do Número:
                //    - Inicialize o número inicial como 15.

                // 2. Laço de Iteração:
                //    - Enquanto o número for menor ou igual a 200, faça:
                //        - Calcule o quadrado do número e exiba-o como saída.
                //        - Incremente o número em 3 unidades.

                int num = 15;
                while (num <= 200)
                {
                    int quadrado = num * num;
                    Console.WriteLine(quadrado);
                    num = num + 3;
                }
            }
            static void Exercicio61()
            {
                Console.WriteLine("Exercício 61: Leitura e Apresentação de Nomes");
                // Passo a Passo:
                int contador = 1;
                List<string> nomes = new List<string>();
                // 1. Inicialização:
                //    - Inicialize um contador como 1 e uma lista vazia para armazenar os nomes.

                // 2. Enquanto o contador for menor ou igual a 10:
                //    - Solicite ao usuário que insira um nome.
                //    - Adicione o nome à lista de nomes.
                //    - Incremente o contador.
                while (contador <= 10)
                {
                    Console.Write("Digite o " + contador + "° nomes: ");
                    string nome = Console.ReadLine();

                    nomes.Add(nome);
                    contador++;
                }
                Console.WriteLine("\nNomes lidos: " + string.Join(",", nomes));


                // 3. Apresentação dos Nomes:
                //    - Apresente os nomes lidos na forma "Nomes lidos: nome1, nome2, ..., nome10".

            }
            static void Exercicio62()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 62: Multiplicação de Elementos de uma Matriz por 3");
                // 1. Entrada de Dados:
                //    - Leia os oito elementos inteiros da matriz.
                //    - Aguarde a entrada dos elementos.
                const int tamanho = 8;
                int[] matriz1 = new int[tamanho];
                int[] matriz2 = new int[tamanho];

                // 2. Construção da Segunda Matriz:
                //    - Para cada elemento da primeira matriz, multiplique por 3 e adicione à segunda matriz.
                // 3. Exibição das Matrizes:
                //    - Apresente os elementos da primeira matriz.
                //    - Apresente os elementos da segunda matriz.
                for (int i = 0; i < tamanho; i++)
                {
                    while (true)
                    {
                        Console.Write($"Insira o elemento {i + 1}/{tamanho}: ");
                        string? entrada = Console.ReadLine();

                        if (int.TryParse(entrada, out int valor))
                        {
                            matriz1[i] = valor;
                            matriz2[i] = valor * 3;
                            break;
                        }
                        Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    }

                }
                Console.WriteLine();
                Console.WriteLine("Matriz original: " + string.Join(",", matriz1));
                Console.WriteLine("Matriz multiplicada por 3:" + string.Join(",", matriz2));





            }
            static void Exercicio63()
            {
                // Passo a Passo:

                Console.WriteLine("Exercício 63: Subtração de Elementos de Matrizes");

                // 1. Entrada de Dados:
                //    - Leia os 20 elementos da primeira matriz.
                //    - Leia os 20 elementos da segunda matriz.
                //    - Aguarde a entrada dos elementos.

                int[] matriz1 = new int[20];
                int[] matriz2 = new int[20];
                int[] matriz3 = new int[20];


                // 2. Inicialização:
                //    - Inicialize a terceira matriz como vazia.
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Digite o " + (i + 1) + "º número: ");
                    matriz1[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Digite o " + (i + 1) + "º número: ");
                    matriz2[i] = int.Parse(Console.ReadLine());
                }

                // 3. Loop de Subtração:
                //    - Para cada posição i, de 0 a 19, da primeira e segunda matriz:
                //      - Subtraia o elemento da posição i da segunda matriz do elemento da posição i da primeira matriz.
                //      - Adicione o resultado à terceira matriz.
                Console.WriteLine("Subitração");

                // 4. Exibição da Matriz Resultante:
                //    - Apresente os elementos da terceira matriz.
                for (int i = 0; i < 20; i++)
                {
                    int elemento = matriz1[i] - matriz2[i];
                    matriz3[i] = elemento;
                    Console.WriteLine(matriz3[i] + " ");


                }

            }
            static void Exercicio64()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 64: Construção de Matriz com Quadrados de Elementos");

                // 1. Entrada de Dados:
                //    - Leia os 15 elementos inteiros.
                //    - Aguarde a entrada dos elementos.
                const int tamanho = 15;
                int[] matriz1 = new int[tamanho];
                int[] matriz2 = new int[tamanho];

                // 2. Inicialização:
                //    - Inicialize a segunda matriz como vazia.

                // 3. Construção da Matriz de Quadrados:
                //    - Para cada elemento da primeira matriz, calcule o quadrado e adicione à segunda matriz.

                // 4. Exibição das Matrizes:
                //    - Apresente os elementos da primeira matriz.
                //    - Apresente os elementos da segunda matriz.
                for (int i = 0; i < tamanho; i++)
                {
                    while (true)
                    {
                        Console.Write($"Insira o elemento {i + 1}/{tamanho}: ");
                        string? entrada = Console.ReadLine();

                        if (int.TryParse(entrada, out int valor))
                        {
                            matriz1[i] = valor;
                            matriz2[i] = matriz1[i] * matriz1[i];
                            break;
                        }
                        Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                    }
                }
                Console.WriteLine("Matriz original: " + string.Join(",", matriz1));
                Console.WriteLine("Matriz dos quadrados:" + string.Join(",", matriz2));





            }
            static void Exercicio65()
            {

                // Passo a Passo:
                const int tamanho = 15;
                int[] matriz1 = new int[tamanho];
                int[] matriz2 = new int[tamanho];

                Console.WriteLine("Exercício 65: Fatorial de Elementos de uma Matriz");

                // 1. Entrada de Dados:
                //    - Leia os 15 elementos inteiros.
                //    - Aguarde a entrada dos elementos.

                // 2. Inicialização:
                //    - Inicialize a segunda matriz como vazia.

                // 3. Cálculo dos Fatoriais:
                //    - Para cada elemento da primeira matriz, calcule o fatorial e adicione à segunda matriz.

                // 4. Exibição das Matrizes:
                //    - Apresente os elementos da primeira matriz.
                //    - Apresente os elementos da segunda matriz.
                for (int j = 0; j < tamanho; j++)
                {
                    while (true)
                    {
                        Console.WriteLine($"Insira o elemento {j + 1}/{tamanho}:");
                        string? entrada = Console.ReadLine();

                        if (int.TryParse(entrada, out int valor) && valor >= 0)
                        {
                            matriz2[j] = valor;

                            int fatorial = 1;

                            for (int i = 1; i <= valor; i++)
                            {
                                fatorial *= i;
                            }
                            matriz2[j] = fatorial;
                            break;
                        }

                    }
                }
                Console.WriteLine("Matriz dos quadrados:" + string.Join(",", matriz2));

            }
            static void Exercicio66()
            {

                // Passo a Passo:
                Console.WriteLine("Exercício 66: Junção de Dois Vetores em um Terceiro");

                // 1. Entrada de Dados:
                //    - Leia os 15 elementos do primeiro vetor.
                //    - Leia os 15 elementos do segundo vetor.
                //    - Aguarde a entrada dos elementos.
                // 2. Inicialização:
                //    - Inicialize o terceiro vetor como vazio.
                int[] vetor1 = new int[15];
                int[] vetor2 = new int[15];
                int[] vetor3 = new int[30];

                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    //numeros[i] =int.Parse(Console.ReadLine());
                    //ou
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    //numeros[i] =int.Parse(Console.ReadLine());
                    //ou
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetor1.Length; i++)
                {
                    vetor3[i] = vetor1[i];

                }
                for (int i = 0; i < vetor2.Length; i++)
                {
                    vetor3[i + 15] = vetor2[i];

                }
                // 3. Construção do Terceiro Vetor:
                //    - Adicione os elementos do primeiro vetor ao terceiro vetor.
                //    - Adicione os elementos do segundo vetor ao terceiro vetor.

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do primeiro vetor.
                //    - Apresente os elementos do segundo vetor.
                //    - Apresente os elementos do terceiro vetor (junção).
                Console.WriteLine($"Vetor1: " + string.Join(",", vetor1));
                Console.WriteLine($"Vetor2: " + string.Join(",", vetor2));
                Console.WriteLine($"Vetor3 (Junção): " + string.Join(",", vetor3));



            }
            static void Exercicio67()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 67: Junção de Dois Vetores de Nomes");

                // 1. Entrada de Dados:
                //    - Leia os 20 elementos do primeiro vetor de nomes.
                //    - Leia os 30 elementos do segundo vetor de nomes.
                //    - Aguarde a entrada dos nomes.
                string[] vetorNomes1 = new string[20];
                string[] vetorNomes2 = new string[30];
                string[] vetorNomes3 = new string[50];

                for (int i = 0; i < vetorNomes1.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º Nome:");

                    vetorNomes1[i] = Console.ReadLine();
                }
                for (int i = 0; i < vetorNomes2.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º Nome:");

                    vetorNomes2[i] = Console.ReadLine();
                }

                // 2. Inicialização:
                //    - Inicialize o terceiro vetor como vazio.

                // 3. Construção do Terceiro Vetor:
                //    - Adicione os nomes do primeiro vetor ao terceiro vetor.
                //    - Adicione os nomes do segundo vetor ao terceiro vetor.
                for (int i = 0; i < vetorNomes1.Length; i++)
                {
                    vetorNomes3[i] = vetorNomes1[i];

                }
                for (int i = 0; i < vetorNomes2.Length; i++)
                {
                    vetorNomes3[i + 20] = vetorNomes2[i];

                }

                // 4. Exibição dos Vetores:
                //    - Apresente os nomes do primeiro vetor.
                //    - Apresente os nomes do segundo vetor.
                //    - Apresente os nomes do terceiro vetor (junção).
                Console.WriteLine($"Nomes do Primeiro Vetor: " + string.Join(",", vetorNomes1));
                Console.WriteLine($"Nomes do Segundo Vetor: " + string.Join(",", vetorNomes2));
                Console.WriteLine($"Todos os nomes: " + string.Join(",", vetorNomes3));





            }
            static void Exercicio68()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 68: Inversão de Elementos em um Vetor");

                // 1. Entrada de Dados:
                //    - Leia os 20 elementos do vetor de números reais.
                //    - Aguarde a entrada dos elementos.
                double[] vetorOriginal = new double[20];
                double[] vetorInvertido = new double[20];

                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine());
                }
                // 2. Inicialização:
                //    - Inicialize o vetor invertido como vazio.
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    vetorInvertido[i] = vetorOriginal[19 - i];
                }

                // 3. Construção do Vetor Invertido:
                //    - Para cada elemento do vetor original, adicione-o ao vetor invertido na posição inversa.

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do vetor original.
                //    - Apresente os elementos do vetor invertido.
                Console.WriteLine($"Vetor Original: " + string.Join(",", vetorOriginal));
                Console.WriteLine($"Vetor Invertido: " + string.Join(",", vetorInvertido));
            }
            static void Exercicio69()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 69: Junção de Três Vetores");
                // 1. Entrada de Dados:
                //    - Leia os cinco elementos do primeiro vetor de inteiros.
                //    - Leia os cinco elementos do segundo vetor de inteiros.
                //    - Leia os cinco elementos do terceiro vetor de inteiros.
                //    - Aguarde a entrada dos elementos.
                int[] vetor1 = new int[5];
                int[] vetor2 = new int[5];
                int[] vetor3 = new int[5];
                int[] vetorResultado = new int[15];

                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");

                    vetor1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");

                    vetor2[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetor3.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");

                    vetor3[i] = Convert.ToInt32(Console.ReadLine());
                }

                // 2. Inicialização:
                //    - Inicialize o vetor resultado como vazio.

                // 3. Construção do Vetor Resultado:
                //    - Adicione os elementos dos três primeiros vetores ao vetor resultado.
                for (int i = 0; i < vetor1.Length; i++)
                {
                    vetorResultado[i] = vetor1[i];

                }
                for (int i = 0; i < vetor2.Length; i++)
                {
                    vetorResultado[i + 5] = vetor2[i];

                }
                for (int i = 0; i < vetor3.Length; i++)
                {
                    vetorResultado[i + 10] = vetor3[i];

                }

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do primeiro vetor.
                //    - Apresente os elementos do segundo vetor.
                //    - Apresente os elementos do terceiro vetor.
                //    - Apresente os elementos do vetor resultado (junção).
                Console.WriteLine($"Vetor1: " + string.Join(",", vetor1));
                Console.WriteLine($"Vetor2: " + string.Join(",", vetor2));
                Console.WriteLine($"Vetor3: " + string.Join(",", vetor3));
                Console.WriteLine($"Vetor Resultado: " + string.Join(",", vetorResultado));


            }
            static void Exercicio70()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 70: Somatório dos Valores até o Elemento Correspondente");

                double[] vetorOriginal = new double[20];
                double[] vetorSomatorio = new double[20];

                // 1. Entrada de Dados:
                //    - Leia os vinte elementos do vetor de inteiros.
                //    - Aguarde a entrada dos elementos.
                // 2. Inicialização:
                //    - Inicialize o segundo vetor como vazio.
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    int somatorio = 0;
                    for (int j = 1; j <= vetorOriginal[i]; j++)
                    {
                        somatorio = somatorio + j;
                    }

                    vetorSomatorio[i] = somatorio;
                }

                // 3. Construção do Vetor com Somatório:
                //    - Para cada elemento do primeiro vetor, calcule o somatório de 1 até o valor do elemento e adicione ao segundo vetor.

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do primeiro vetor.
                //    - Apresente os elementos do segundo vetor.
                Console.WriteLine($"Vetor Original: " + string.Join(",", vetorOriginal));
                Console.WriteLine($"Vetor Somatorio: " + string.Join(",", vetorSomatorio));
            }
            static void Exercicio71()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 71: Vetor com Valores Negativos");

                double[] vetorOriginal = new double[10];
                double[] vetorNegativo = new double[10];


                // 1. Entrada de Dados:
                //    - Leia os dez elementos do vetor de inteiros positivos.
                //    - Aguarde a entrada dos elementos.
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    vetorNegativo[i] = vetorOriginal[i] * -1;
                }
                // 2. Inicialização:
                //    - Inicialize o segundo vetor como vazio.

                // 3. Construção do Vetor com Valores Negativos:
                //    - Para cada elemento do primeiro vetor, calcule o valor negativo e adicione ao segundo vetor.

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do primeiro vetor.
                //    - Apresente os elementos do segundo vetor.
                Console.WriteLine($"Vetor Original: " + string.Join(",", vetorOriginal));
                Console.WriteLine($"Vetor Negativo: " + string.Join(",", vetorNegativo));

            }
            static void Exercicio72()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 72: Divisão por Dois dos Elementos de um Vetor");
                int[] vetorOriginal = new int[10];
                double[] vetorMetade = new double[10];

                // 1. Entrada de Dados:
                //    - Leia os dez elementos do vetor de inteiros.
                //    - Aguarde a entrada dos elementos.
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Digite o valor " + (i + 1) + ": ");
                    vetorOriginal[i] = int.Parse(Console.ReadLine());

                    // Calcula a metade
                    vetorMetade[i] = vetorOriginal[i] / 2.0;
                }

                // 2. Inicialização:
                //    - Inicialize o segundo vetor como vazio.

                // 3. Construção do Vetor com Metade dos Valores:
                //    - Para cada elemento do primeiro vetor, calcule a metade e adicione ao segundo vetor.

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do primeiro vetor.
                //    - Apresente os elementos do segundo vetor.
                Console.WriteLine();
                Console.WriteLine("Vetor Original: ");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(vetorOriginal[i] + "");
                }

                Console.WriteLine("Vetor com metade dos valores:");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(vetorMetade[i] + " ");
                }


            }
            static void Exercicio73()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 73: Tabuada em um Vetor");

                int[] tabuada = new int[10];

                Console.Write("Digite o valor da tabuada: ");
                int valor = int.Parse(Console.ReadLine());

                // Calcula e armazena a tabuada no veto
                for (int i = 0; i < 10; i++)
                {
                    tabuada[i] = valor * (i + 1);
                }

                Console.WriteLine();
                Console.WriteLine("Tabuada do " + valor + ":");
                Console.WriteLine();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(
                        valor + " x " + (i + 1) + " = " + tabuada[i]
                    );
                }


            }
            static void Exercicio74()
            {
                Console.WriteLine("Exercício 74: Análise de Temperaturas em Graus Celsius");

                double[] temperaturas = new double[20];

                double menor = double.MaxValue;
                double maior = double.MinValue;
                double soma = 0;

                // Entrada das 20 temperaturas
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("Digite a temperatura " + (i + 1) + " em °C: ");
                    temperaturas[i] = double.Parse(Console.ReadLine());

                    if (temperaturas[i] < menor)
                    {
                        menor = temperaturas[i];
                    }

                    if (temperaturas[i] > maior)
                    {
                        maior = temperaturas[i];
                    }

                    soma += temperaturas[i];
                }

                double media = soma / 20;
                Console.WriteLine("================ Temperaturas ==================");
                Console.WriteLine("Menor temperatura: " + menor + " °C");
                Console.WriteLine("Maior temperatura: " + maior + " °C");
                Console.WriteLine("Média das temperaturas: " + media.ToString("F2") + " °C");
                Console.WriteLine("================================================");
                Console.WriteLine();

            }
            static void Exercicio75()
            {
                Console.WriteLine("Exercício 75: Conversão de Temperaturas de Celsius para Fahrenheit");


                double[] vetorCelsius = new double[25];
                double[] vetorFahrenheit = new double[25];


                // Entrada das 25 temperaturas
                for (int i = 0; i < 25; i++)
                {
                    Console.Write("Digite a temperatura " + (i + 1) + " em Celsius: ");
                    vetorCelsius[i] = double.Parse(Console.ReadLine());

                    // Conversão para Fahrenheit
                    vetorFahrenheit[i] = (vetorCelsius[i] * 9 / 5) + 32;
                }

                Console.WriteLine();
                Console.WriteLine("====================");
                Console.WriteLine(" Vetor em Celsius  ");
                Console.WriteLine("====================");

                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine(vetorCelsius[i].ToString("F2") + " °C   ");
                }

                Console.WriteLine();


                Console.WriteLine("=======================");
                Console.WriteLine(" Vetor em Fahrenheit ");
                Console.WriteLine("=======================");

                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine(vetorFahrenheit[i].ToString("F2") + " °F   ");
                }









            }
            static void Exercicio76()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 76: Manipulação de Elementos de um Vetor");

                int[] vetorOriginal = new int[12];
                int[] vetorResultante = new int[12];
                int posicao = 0;


                // 1. Entrada de Dados:
                //    - Leia os 12 elementos do vetor de inteiros.
                //    - Aguarde a entrada dos valores.
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    if (vetorOriginal[i] % 2 != 0)
                    {
                        vetorResultante[posicao] = vetorOriginal[i] * 2;
                        posicao++;

                    }
                }

                Console.WriteLine("Vetor Original: " + string.Join(", ", vetorOriginal));

                // Mostra somente as posições que realmente receberam resultado
                Console.WriteLine("Vetor Resultante: " +
                    string.Join(", ", vetorResultante[..posicao]));
            }
            static void Exercicio77()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 77: Manipulação de Elementos de um Vetor");

                double[] vetorOriginal = new double[15];
                double[] vetorResultante = new double[15];
                int posicao = 0;

                // 1. Entrada de Dados:
                //    - Leia os 15 elementos do vetor de números reais.
                //    - Aguarde a entrada dos valores.
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetorOriginal[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetorOriginal.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vetorResultante[posicao] = vetorOriginal[i] / 2;
                        posicao++;
                    }
                    else
                    {
                        vetorResultante[posicao] = vetorOriginal[i] * 1.5;
                        posicao++;
                    }
                }
                // 2. Inicialização:
                //    - Inicialize o segundo vetor como vazio.

                // 3. Manipulação dos Elementos:
                //    - Para cada elemento do primeiro vetor, verifique se o índice é par; se for, divida por 2; caso contrário, multiplique por 1.5 e adicione ao segundo vetor.

                // 4. Exibição dos Vetores:
                //    - Apresente os elementos do primeiro vetor.
                //    - Apresente os elementos do segundo vetor.
                Console.WriteLine("Vetor Original: " + string.Join(" ", vetorOriginal));

                // Mostra somente as posições que realmente receberam resultado
                Console.WriteLine("Vetor Resultante: " +
                    string.Join(" ", vetorResultante[..posicao]));
            }
            static void Exercicio78()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 78: Manipulação de Índices de Matrizes");

                int[] vetor1 = new int[6];
                int[] vetor2 = new int[6];
                int[] pares = new int[6];
                int[] impares = new int[6];

                // 1. Entrada de Dados:
                //    - Leia os seis elementos para as duas matrizes.
                //    - Aguarde a entrada dos valores.
                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número:");
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());
                }

                // 2. Inicialização:
                //    - Inicialize as duas novas matrizes (pares e ímpares) como vazias.
                int indicepar = 0;
                int indiceimpar = 0;

                // 3. Construção das Novas Matrizes:
                //    - Para cada elemento de índice par, adicione à matriz de índices pares; para ímpar, adicione à matriz de índices ímpares.
                for (int i = 0; i < vetor1.Length; i++)
                {
                    if (vetor1[i] % 2 == 0)
                    {
                        pares[indicepar] = vetor1[i];
                        indicepar++;
                    }
                    else
                    {
                        impares[indiceimpar] = vetor1[i];
                        indiceimpar++;
                    }
                }

                // Verificando os VALORES do vetor 2
                for (int i = 0; i < vetor2.Length; i++)
                {
                    if (vetor2[i] % 2 == 0)
                    {
                        pares[indicepar] = vetor2[i];
                        indicepar++;
                    }
                    else
                    {
                        impares[indiceimpar] = vetor2[i];
                        indiceimpar++;
                    }
                }

                // 4. Exibição das Matrizes:
                //    - Apresente os elementos das duas matrizes originais.

                Console.WriteLine();

                Console.Write("\nVetor 1: ");
                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.Write(vetor1[i] + " ");
                }

                Console.WriteLine();

                // Vetor 2
                Console.Write("\nVetor 2: ");
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.Write(vetor2[i] + " ");
                }


                Console.WriteLine();
                //    - Apresente os elementos da matriz de índices pares.

                Console.Write("\nValores pares: ");
                for (int i = 0; i < indicepar; i++)
                {
                    Console.Write(pares[i] + " ");
                }

                Console.WriteLine();

                //    - Apresente os elementos da matriz de índices ímpares.
                Console.Write("\nValores ímpares: ");
                for (int i = 0; i < indiceimpar; i++)
                {
                    Console.Write(impares[i] + " ");
                }
                Console.WriteLine();

            }
            static void Exercicio79()
            {
                Console.WriteLine("Exercício 79: Junção de Vetores com Validação de Entrada");

                int[] vetorA = new int[6];
                int[] vetorB = new int[6];
                int[] vetorC = new int[12];

                // Preenchendo o vetor A com números pares
                for (int i = 0; i < 6; i++)
                {
                    Console.Write($"Digite um valor PAR para A[{i}]: ");
                    vetorA[i] = int.Parse(Console.ReadLine());

                    while (vetorA[i] % 2 != 0)
                    {
                        Console.Write("Valor inválido! Digite um número PAR: ");
                        vetorA[i] = int.Parse(Console.ReadLine());
                    }
                }

                // Preenchendo o vetor B com números ímpares
                for (int i = 0; i < 6; i++)
                {
                    Console.Write($"Digite um valor ÍMPAR para B[{i}]: ");
                    vetorB[i] = int.Parse(Console.ReadLine());

                    while (vetorB[i] % 2 == 0)
                    {
                        Console.Write("Valor inválido! Digite um número ÍMPAR: ");
                        vetorB[i] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();

                // Construindo o vetor C
                for (int i = 0; i < 6; i++)
                {
                    vetorC[i] = vetorA[i];
                    vetorC[i + 6] = vetorB[i];
                }

                // Exibindo o vetor A
                Console.WriteLine("\nVetor A:");
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(vetorA[i] + " ");
                }

                // Exibindo o vetor B
                Console.WriteLine("\n\nVetor B:");
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(vetorB[i] + " ");
                }

                // Exibindo o vetor C
                Console.WriteLine("\n\nVetor C:");
                for (int i = 0; i < 12; i++)
                {
                    Console.Write(vetorC[i] + " ");
                }

                Console.ReadKey();

            }
            static void Exercicio80()
            {
                Console.WriteLine("Exercício 80: Junção de Vetores com Validação de Entrada");

                int[] vetor1 = new int[10];
                int[] vetor2 = new int[10];
                int[] vetor3 = new int[20];

                // 1. Entrada e validação do vetor 1

                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.Write($"Digite um valor divisível por 2 e 3 para o vetor 1 [{i}]: ");
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());

                    while (vetor1[i] % 2 != 0 || vetor1[i] % 3 != 0)
                    {
                        Console.Write("Valor inválido! Digite um valor divisível por 2 e 3: ");
                        vetor1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // 2. Entrada e validação do vetor 2

                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.Write($"Digite um múltiplo de 5 para o vetor 2 [{i}]: ");
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());

                    while (vetor2[i] % 5 != 0)
                    {
                        Console.Write("Valor inválido! Digite um múltiplo de 5: ");
                        vetor2[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // 3. Construção do vetor 3

                for (int i = 0; i < 10; i++)
                {
                    vetor3[i] = vetor1[i];
                    vetor3[i + 10] = vetor2[i];
                }

                // 4. Exibição do vetor 1

                Console.WriteLine("\nVetor 1:");

                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.Write(vetor1[i] + " ");
                }

                // 5. Exibição do vetor 2

                Console.WriteLine("\n\nVetor 2:");

                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.Write(vetor2[i] + " ");
                }

                // 6. Exibição do vetor 3

                Console.WriteLine("\n\nVetor 3:");

                for (int i = 0; i < vetor3.Length; i++)
                {
                    Console.Write(vetor3[i] + " ");
                }

                Console.WriteLine();
            }
            static void Exercicio81()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 81: Junção de Vetores com Validação de Entrada");
                // É o mesmo exercicio da questão 80.

                int[] vetor1 = new int[10];
                int[] vetor2 = new int[10];
                int[] vetor3 = new int[20];

                // 1. Entrada de Dados:
                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.Write($"Digite um valor divisível por 2 e 3 para o vetor 1 [{i}]: ");
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());

                    while (vetor1[i] % 2 != 0 || vetor1[i] % 3 != 0)
                    {
                        Console.Write("Valor inválido! Digite um valor divisível por 2 e 3: ");
                        vetor1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.Write($"Digite um múltiplo de 5 para o vetor 2 [{i}]: ");
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());

                    while (vetor2[i] % 5 != 0)
                    {
                        Console.Write("Valor inválido! Digite um múltiplo de 5: ");
                        vetor2[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < 10; i++)
                {
                    vetor3[i] = vetor1[i];
                    vetor3[i + 10] = vetor2[i];
                }

                // 4. Exibição do vetor 1

                Console.WriteLine("\nVetor 1:");

                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.Write(vetor1[i] + " ");
                }

                // 5. Exibição do vetor 2

                Console.WriteLine("\n\nVetor 2:");

                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.Write(vetor2[i] + " ");
                }

                // 6. Exibição do vetor 3

                Console.WriteLine("\n\nVetor 3:");

                for (int i = 0; i < vetor3.Length; i++)
                {
                    Console.Write(vetor3[i] + " ");
                }

                Console.WriteLine();
            }
            static void Exercicio82()
            {

                // Passo a Passo:
                Console.WriteLine(" Exercício 82: Contagem de Números Pares e Ímpares em um Vetor");

                int[] vetor = new int[30];

                int pares = 0;
                int impares = 0;

                // 1. Entrada de Dados:
                //    - Leia os 30 elementos para o vetor.
                //    - Aguarde a entrada dos valores.
                // 2.Contagem de Números Pares e Ímpares:
                //    - Para cada elemento do vetor, verifique se é par ou ímpar e incremente o contador correspondente.
                Console.WriteLine();
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write("Digite o elemento " + (i + 1) + " do vetor: ");
                    vetor[i] = Convert.ToInt32(Console.ReadLine());
                    if (vetor[i] % 2 == 0)
                    {
                        pares = pares + 1;
                    }
                    else
                    {
                        impares = impares + 1;
                    }

                }
                // 3. Exibição dos Resultados:
                //    - Apresente as quantidades de números pares e ímpares no vetor.
                Console.WriteLine();
                Console.WriteLine($"Quantidade de números pares: {pares}");
                Console.WriteLine();
                Console.WriteLine($"Quantidade de números ímpares: {impares}");
                Console.WriteLine();


            }
            static void Exercicio83()
            {
                // Passo a Passo:
                Console.WriteLine("Exercício 83: Construção de um Vetor a partir do Quadrado da Soma de Outros Dois Vetores");

                int[] vetor1 = new int[10];
                int[] vetor2 = new int[10];
                int[] vetor_resultante = new int[20];

                // 1. Entrada de Dados:
                //    - Leia os dez elementos para o vetor 1.
                //    - Leia os dez elementos para o vetor 2.
                //    - Aguarde a entrada dos valores.
                Console.WriteLine();
                for (int i = 0; i < vetor1.Length; i++)
                {
                    Console.Write("Digite o elemento " + (i + 1) + " do vetor 1: ");
                    vetor1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < vetor2.Length; i++)
                {
                    Console.Write("Digite o elemento " + (i + 1) + " do vetor 2: ");
                    vetor2[i] = Convert.ToInt32(Console.ReadLine());
                }
                // 2. Construção do Vetor Resultante:
                //    - Para cada elemento de índice i nos vetores 1 e 2, calcule o quadrado da soma dos elementos correspondentes e adicione ao vetor resultante.
                Console.WriteLine();
                for (int i = 0; i < vetor_resultante.Length; i++)
                {
                    int soma = vetor1[i] + vetor2[i];
                    int quadrado = soma ^ 2;
                    quadrado = vetor_resultante[i];
                }
                // 3. Exibição do Vetor Resultante:
                //  - Apresente os elementos do vetor resultante.
                Console.WriteLine($"Vetor resultante: {vetor_resultante} ");
            }
            static void Exercicio84()
            {
                // Passo a Passo:
                Console.WriteLine("Exercicio 84: Construção de uma Segunda Matriz a partir de um Vetor ");

                int[] vetor = new int[10];
                int[] vetor_resultante = new int[10];

                // 1. Entrada de Dados:
                //    - Leia os seis elementos para o vetor.
                //    - Aguarde a entrada dos valores.
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        vetor[i] = 0;
                    }
                }

                // 2. Construção do Vetor Resultante:
                //    - Para cada elemento de índice i no vetor, verifique se o índice é par ou ímpar.
                //    - Se for par, adicione o elemento na posição ímpar no vetor resultante; se for ímpar, adicione na posição par.

                // 3. Exibição do Vetor Resultante:
                //    - Apresente os elementos do vetor resultante.
            }
            static void Exercicio85()
            {

            }
            static void Exercicio86()
            {

            }
            static void Exercicio87()
            {

            }
            static void Exercicio88()
            {

            }
            static void Exercicio89()
            {

            }
            static void Exercicio90()
            {

            }
            static void Exercicio91()
            {

            }
            static void Exercicio92()
            {

            }
            static void Exercicio93()
            {

            }
            static void Exercicio94()
            {

            }
            static void Exercicio95()
            {

            }
            static void Exercicio96()
            {

            }
            static void Exercicio97()
            {

            }
            static void Exercicio98()
            {

            }
            static void Exercicio99()
            {

            }
            static void Exercicio100()
            {

            }
            static void Exercicio101()
            {

            }
            static void Exercicio102()
            {

            }
            static void Exercicio103()
            {

            }
            static void Exercicio104()
            {

            }
            static void Exercicio105()
            {

            }
            static void Exercicio106()
            {

            }
            static void Exercicio107()
            {

            }
            static void Exercicio108()
            {

            }
            static void Exercicio109()
            {

            }
            static void Exercicio110()
            {

            }
            static void Exercicio111()
            {

            }
            static void Exercicio112()
            {

            }
            static void Exercicio113()
            {

            }
            static void Exercicio114()
            {

            }
            static void Exercicio115()
            {

            }
            static void Exercicio116()
            {

            }
            static void Exercicio117()
            {

            }
            static void Exercicio118()
            {

            }
            static void Exercicio119()
            {

            }
            static void Exercicio120()
            {

            }


        }
        
    } 
}
       
    
