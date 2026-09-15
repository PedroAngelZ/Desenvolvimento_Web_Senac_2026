namespace Supermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=============================================================");
            Console.WriteLine("||         Sistema de Caixa de Supermercado (C#)           ||");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.ResetColor();

            // Para passar um produto digite a identificação mais o numero por exemplo PE-03 que é o teclado

            List<Produto> produtosDisponiveis = new List<Produto>();

            // Produtos comuns PC codigo
            produtosDisponiveis.Add(new Produto("PC-01", "Arroz 5kg", 24.99, 50));

            produtosDisponiveis.Add(new Produto("PC-02", "Feijão 1kg", 10.99, 40));

            produtosDisponiveis.Add(new Produto("PC-03", "Sal 1kg", 8.99, 45));

            produtosDisponiveis.Add(new Produto("PC-04", "Açucar 1kg", 9.99, 60));

            produtosDisponiveis.Add(new Produto("PC-05", "Oleo", 11.99, 40));

            produtosDisponiveis.Add(new Produto("PC-06", "Azeite", 50.99, 40));

            produtosDisponiveis.Add(new Produto("PC-07", "Bolacha Recheada", 3.25, 80));

            produtosDisponiveis.Add(new Produto("PC-08", "Café", 34.99, 40));

            produtosDisponiveis.Add(new Produto("PC-09", "Nescau", 13.99, 60));

            produtosDisponiveis.Add(new Produto("PC-10", "Salgadinho", 8.99, 60));

            // Produtos perecíveis PP codigo
            produtosDisponiveis.Add(new ProdutoPerecivel("PP-01", "Iogurte Morango", 8.99, 20, 4));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-02", "Leite Pasteurizado", 6.49, 30, 5));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-03", "Queijo fatiado 250g", 9.99, 15, 15));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-04", "Presunto fatiado 250g", 8.99, 10, 7));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-05", "Ovo da Granja Bandeja/30", 33.99, 10, 30));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-06", "Pão de Queijo unid", 2.99, 15, 3));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-07", "Bolo de Fuba", 14.99, 20, 10));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-08", "Pudim de Leite Condensado", 14.99, 20, 7));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-09", "Limão 1Kg", 3.49, 5, 2));

            produtosDisponiveis.Add(new ProdutoPerecivel("PP-10", "Requeijão", 7.99, 20, 5));

            // Produtos eletrônicos PE codigo

            produtosDisponiveis.Add(new ProdutoEletronico("PE-01", "Celular", 1499.99, 10, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-02", "Fone de Ouvido", 139.99, 25, 6));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-03", "Teclado", 99.99, 20, 3));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-04", "TV 4K", 3599.99, 10, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-05", "Notebook", 2599.99, 15, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-06", "Liquidificador", 189.99, 10, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-07", "Cafeteira", 219.99, 15, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-08", "Caixa de Som", 199.99, 20, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-09", "Ventilador", 169.99, 10, 12));

            produtosDisponiveis.Add(new ProdutoEletronico("PE-10", "Micro-ondas", 449.99, 10, 12));



            // Lista polimórfica
            List<ProdutonoCarrinho> carrinhoDeCompras = new List<ProdutonoCarrinho>();

            string opcao;

            do
            {
                // Painel dos produtos
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=== Produtos Disponiveis ==========================");

                foreach (Produto produto in produtosDisponiveis)
                {
                    Console.WriteLine($"{produto.Codigo} - {produto.Nome} - R$ {produto.PrecoUnitario:F2}");
                }
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("Digite o código do produto que deseja comprar.");
                Console.WriteLine("Digite 0 para finalizar a compra");
                Console.Write("Escolha: ");
                Console.ResetColor();

                opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    break;
                }

                Produto produtoEscolhido = null;

                foreach (Produto produto in produtosDisponiveis)
                {
                    if (produto.Codigo == opcao)
                    {
                        produtoEscolhido = produto;
                        break;
                    }

                }

                if (produtoEscolhido == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Produto não encontrado!");
                    Console.ResetColor();
                    continue;
                }
                Console.WriteLine();
                Console.WriteLine($"Produto escolhido: {produtoEscolhido.Nome}");
                Console.WriteLine($"Preço: R$ {produtoEscolhido.PrecoUnitario:F2}");
                Console.WriteLine($"Estoque disponível: {produtoEscolhido.QuantidadeEstoque}");

                Console.WriteLine("Digite a quantidade desejada: ");

                int quantidade;

                if (!int.TryParse( Console.ReadLine(), out quantidade))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Quantidade inválida!");
                    Console.ResetColor();
                    continue;
                }

                if (quantidade <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("A quantidade deve ser maior que zero.");
                    Console.ResetColor();
                    continue;
                }

                if (quantidade > produtoEscolhido.QuantidadeEstoque)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Quantidade maior que o estoque disponível! ");
                    Console.ResetColor();
                    continue;
                }
                carrinhoDeCompras.Add(new ProdutonoCarrinho(produtoEscolhido, quantidade));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Produto adicionado ao carrinho! ");
                Console.ResetColor();

            } while (true);

            Console.Clear();
            Console.WriteLine();


            // Nota fiscal das compras
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=== Cupom Fiscal ===================================");
            double valorTotal = 0;
            if (carrinhoDeCompras.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Nenhum produto foi comprado. ");
            }
            else 
            { 
                foreach (ProdutonoCarrinho item in carrinhoDeCompras)
                {
                    Produto produto = item.Produto;
                    Console.WriteLine();
                    produto.ExibirDetalhes();
                    double descontoUnitario = produto.CalcularDesconto();
                    double precoUnitarioFinal = produto.PrecoUnitario - descontoUnitario;
                    double descontoTotal = descontoUnitario * item.Quantidade;
                    double subtotal = precoUnitarioFinal * item.Quantidade;
                    Console.WriteLine($"Quantidade: {item.Quantidade}");
                    Console.WriteLine($"Preço unitário: R$ {produto.PrecoUnitario:F2}");
                    Console.WriteLine($"Desconto por unidade: R$ {descontoUnitario:F2}");
                    Console.WriteLine($"Desconto total: R$ {descontoTotal:F2}");
                    Console.WriteLine($"Subtotal: R$ {subtotal:F2}");

                    Console.WriteLine("===================================================");

                    valorTotal += subtotal;
                }
                Console.WriteLine();
                Console.WriteLine($"Total da compra: R$ {valorTotal:F2}");
                Console.WriteLine("Obrigado pela compra!");
                Console.ResetColor();
                Console.ReadLine();
            
            }



        }
        // Tudo que o usuario colocar no carrinho 
        class ProdutonoCarrinho 
        { 
            public Produto Produto { get; private set; }

            public int Quantidade { get; private set; }

            public ProdutonoCarrinho(Produto produto, int quantidade)
            {
                Produto = produto;
                Quantidade = quantidade;
            }
        
        }

        // Classe Pai
        class Produto
        {
            public string Codigo { get; private set; }
            public string Nome { get; private set; }
            public double PrecoUnitario {  get; private set; }
            public int QuantidadeEstoque {  get;private set; }


            public Produto(string codigo, string nome, double precoUnitario, int quantidadeEstoque)
            {
                Codigo = codigo;
                Nome = nome;
                this.PrecoUnitario = precoUnitario;
                this.QuantidadeEstoque = quantidadeEstoque;
            }

            public virtual void ExibirDetalhes()
            {
                Console.WriteLine($"Codigo: {Codigo} | Produto: {Nome}");
                Console.WriteLine($"Estoque disponivel: {QuantidadeEstoque} ");
            }
            public virtual double CalcularDesconto() 
            {
                return 0; 
            }

        }

        // Classe filha Perecivel
        class ProdutoPerecivel : Produto
        {
            public int DiasParaVencer {  get; private set; }

            public ProdutoPerecivel(string codigo, string nome, double precoUnitario, int QuantidadeEstoque, int diasParaVencer)
                : base(codigo, nome, precoUnitario, QuantidadeEstoque)
            {
                DiasParaVencer = diasParaVencer;
            }

            public override double CalcularDesconto()
            {
                if (DiasParaVencer <= 3)
                {
                    return PrecoUnitario * 0.50;
                }

                return 0;
            }

            public override void ExibirDetalhes() 
            { 
                base.ExibirDetalhes();
                Console.WriteLine($"Dias para vencer: {DiasParaVencer}");
            }


        }

        // Classe filha Eletronico
        class ProdutoEletronico : Produto 
        { 
            public int Mesesgarantia { get; private set; }

            public ProdutoEletronico(string codigo, string nome, double precoUnitario, int quantidadeEstoque, int mesesGarantia)
                : base(codigo, nome, precoUnitario, quantidadeEstoque) 
            { 
                Mesesgarantia = mesesGarantia;
            }

            public override void ExibirDetalhes()
            {
                base.ExibirDetalhes();
                Console.WriteLine($"Garantia: {Mesesgarantia} meses");
            }
        }

    }
}
