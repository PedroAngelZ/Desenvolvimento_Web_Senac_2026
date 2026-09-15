

using System.ComponentModel;
using System.Diagnostics;
 
namespace ExpançãoDoReino
{
    internal class Program
    {
        // O que falta ser implementado no RPG:
        // Melhorar o sistema de cura.
        // Melhorar o combate:
        // ao terminar a batalha os personagem tem posiblidade de se curarem ou de continuar
        // ao continuar inicia outro combate
        // ter um sistema de turno entre os personagens e os inimigos
        // ter 6 combates até chegar no dragão:
        // 1° 2goblins
        // 2° 3 goblins
        // 3° 4 goblins
        // 4° 2 aranhas gigantes
        // 5° 1 orc e 2 goblins
        // 6° 2 orc e 2 goblins
        // 7° Dragão vermelho Final/ chave para o tesouro do dragão e uma passagem para saida
        // Criar um sistema de xp que com seu aumento de nivel aumenta o dano do personagem



        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========================================================================================");
            Console.WriteLine("   ||                                                                              || ");
            Console.WriteLine("   ||                       BEM-VINDO AO RPG DO COVIL DO DRAGÃO !                  ||");
            Console.WriteLine("   ||                                 EM LINGUAGEM C#                              || ");
            Console.WriteLine("   ||                                                                              || ");
            Console.WriteLine("========================================================================================");
            Console.ResetColor();

            // Aqui é só uma introdução da história dos heróis durante missão
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================================================================");
            Console.WriteLine("||                           HISTÓRIA DA JORNADA DOS HERÓIS                           ||");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("   Os heróis Aragorn, Gadanlf e Raphael foram convocados pelo rei de Valerion para uma     ");
            Console.WriteLine("  missão perigosa. Enfrentar o Rei dos Goblins que fez um acordo com o Dragão Vermelho        ");
            Console.WriteLine("  que se ele ajuda-se a queimar o reino, ele ficava com todo o ouro e goblins com reino ");
            Console.WriteLine("  de Valerion. Atraves de um patrulheiro eles conseguiram a localização do  Covil do  ");
            Console.WriteLine("  Dragão, que é um antigo santuario esquecido. ");
            Console.WriteLine("   Os heróis devem atravessar a Floresta Densa onde fica o Covil. Ao chegarem perto       ");
            Console.WriteLine("  do Covil, eles encontram o Rei dos Goblins e seus soldados, que estão protegendo a   ");
            Console.WriteLine("  entrada");
            Console.WriteLine("========================================================================================");
            Console.ResetColor();


            // Criando uma lista polimórfica de heróis
            List<Personagem> grupoHerois = new List<Personagem>();

            // Instanciando um guerreiro
            // ANTES: aragorn.Vida = 140; (atribuição livre, quebrava o encapsulamento)
            // AGORA: os valores são passados pelo construtor, que fica responsável
            // por validar e inicializar Vida/Nivel corretamente.
            Guerreiro aragorn = new Guerreiro("Aragorn", 6, 140, 35, 45);

            // Instanciando um mago
            Mago gadanlf = new Mago("Gadanlf", 5, 130, 70, 140);

            // Instanciando um Arqueiro
            Arqueiro raphael = new Arqueiro("Raphael", 5, 120, 40, 15);


            //Adicionado os hérois na lista
            grupoHerois.Add(gadanlf);
            grupoHerois.Add(aragorn);
            grupoHerois.Add(raphael);


            // Aqui eu vou criar 6 combates, e no final os hérois vão enfrentar o dragão vermelho
            // que é o boss final do jogo e liberar a chave do tesouro do dragão e uma passagem para saida do jogo


            //  COMBATE 1: 2 Goblins
            // =====================================================================
            // Para isso vou criar uma lista para adicionar os inimigos do combate 1
            // ANTES: new Personagem { Nome = "...", Vida = ..., ... } (inicializador de objeto)
            // AGORA: os inimigos também usam o construtor, já que Vida/Nivel não podem
            // mais ser atribuídos diretamente de fora da classe.
            List<Personagem> inimigosCombate1 = new List<Personagem>
            {
                // adicionando os goblins na lista de inimigos do combate 1
                new Personagem("Goblin Malvado", 3, 100, 12),
                new Personagem("Goblin Bebado", 5, 130, 15)
            };

            // COMBATE 2 : 3 Goblins
            // =====================================================================
            // Lista de inimigos do combate 2
            List<Personagem> inimigosCombate2 = new List<Personagem>
            {
                new Personagem("Goblin Soldado", 7, 120, 20),
                new Personagem("Goblin Malvado", 5, 100, 15),
                new Personagem("Goblin Feiticeiro", 8, 90, 25)
            };

            // COMBATE 3: 4 Goblins
            // =====================================================================
            // Lista de inimigos do combate 3
            List<Personagem> inimigosCombate3 = new List<Personagem>
            {
                new Personagem("Goblin Arqueiro", 5, 100, 15),
                new Personagem("Goblin Gordo", 10, 200, 30),
                new Personagem("Goblin Feiticeiro", 8, 90, 30),
                new Personagem("Goblin Soldado", 6, 120, 20)
            };
            // COMBATE 4: 2 Aranhas Gigantes
            // =====================================================================
            // Lista de inimigos do combate 4
            List<Personagem> inimigosCombate4 = new List<Personagem>
            {
                new Personagem("Aranha Gigante", 9, 220, 30),
                new Personagem("Aranha Caçadora", 10, 200, 35)
            };

            // COMBATE 5: 1 Orc e 2 Goblins
            // =====================================================================
            // Lista de inimigos do combate 5
            List<Personagem> inimigosCombate5 = new List<Personagem>
            {
                new Personagem("Orc Glutão", 10, 420, 40),
                new Personagem("Goblin Malvado", 5, 100, 12),
                new Personagem("Goblin Feiticeiro", 8, 90, 30)
            };
            // COMBATE 6: 2 Orcs e 2 Goblins
            // =====================================================================
            // Lista de inimigos do combate 6
            List<Personagem> inimigosCombate6 = new List<Personagem>
            {
                new Personagem("Orc Colosso", 12, 420, 35),
                new Personagem("Orc Glutão", 10, 420, 40),
                new Personagem("Goblin Feiticeiro", 8, 90, 30),
                new Personagem("Goblin Rei", 15, 400, 50),
                new Personagem("Goblin Arqueiro", 8, 90, 30)
            };

            // COMBATE FINAL: Dragão Vermelho
            // =====================================================================
            // Lista do boss para o combate final
            List<Personagem> bossFinal = new List<Personagem>
            {
                new Personagem("Dragão Vermelho", 40, 820, 65)
            };

            // LISTAGEM DE COMBATES DA CAMPANHA
            // =====================================================================
            List<List<Personagem>> combatesCampanha = new List<List<Personagem>>
            {
                inimigosCombate1,
                inimigosCombate2,
                inimigosCombate3,
                inimigosCombate4,
                inimigosCombate5,
                inimigosCombate6,
                bossFinal
            };

            // MOVIMENTAÇÃO DOS HERÓIS ANTES DO PRIMEIRO COMBATE
            // =====================================================================
            // Demonstração de polimorfismo: percorremos a lista polimórfica
            // grupoHerois (List<Personagem>) chamando Mover() em cada um,
            // antes da primeira batalha começar.
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=== Os heróis se movimentam em direção ao Covil do Dragão ===");
            Console.ResetColor();
            foreach (Personagem heroi in grupoHerois)
            {
                heroi.Mover();
            }
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();

            // EXECUTAÇÃO DA CAMPANHA
            // =====================================================================

            for (int i = 0; i < combatesCampanha.Count; i++)
            {
                bool venceu = Combate.Iniciar(grupoHerois, combatesCampanha[i], i + 1);

                if (!venceu)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("======================================= GAME OVER ! ====================================");
                    Console.WriteLine("||                                                                                    ||");
                    Console.WriteLine("||     A campanha terminou! Os heróis foram derrotados e o reino está destruido !!    ||");
                    Console.WriteLine("||                                                                                    ||");
                    Console.WriteLine("========================================================================================");
                    Console.ResetColor();
                    break;
                }

                // se a campanha não terminou
                if (i < combatesCampanha.Count - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("=== Preparando para o próximo Combate ===");
                    Console.ResetColor();

                    // perguntar se deseja curar o grupo antes do próximo combate
                    Console.WriteLine();
                    Console.WriteLine("Deseja curar o grupo?");
                    Console.WriteLine("1 - Sim");
                    Console.WriteLine("2 - Continuar sem curar");
                    Console.Write("Escolha: ");

                    string escolha = Console.ReadLine();

                    if (escolha == "1")
                    {
                        foreach (var heroi in grupoHerois)
                        {
                            if (heroi.Estavivo())
                            {
                                heroi.Curar(70); // Curar 70 HP
                            }
                        }
                    }
                    foreach (Personagem heroi in grupoHerois)
                    {
                        if (heroi.Estavivo())
                        {
                            heroi.Mover();
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Os heróis chegaram ao próximo local!");
                    Console.WriteLine();

                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();

                }
                if (i == combatesCampanha.Count - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine();
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("||                        DRAGÃO VERMELHO DERROTADO!                    ||");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine();
                    Console.WriteLine("     Depois de batalhar bravamente contra o rei goblin e seus soldados,      ");
                    Console.WriteLine("    e o terrivel dragão vermelho. Trouxeram paz ao reino de Valerion.      ");
                    Console.WriteLine("     Quando os heróis se aproximam do corpo do dragão... eles encontram   ");
                    Console.WriteLine("    perto dele uma chave dourada, quando o Aragorn encosta na chave é     ");
                    Console.WriteLine("    revelado um portão enorme ilusório onde ficava todo ouro do Dragão!   ");
                    Console.WriteLine("     Os heróis se aproximam do portão e o portão se abre revelando um       ");
                    Console.WriteLine("    enorme tesouro de ouro, joias e artefatos mágicos. Eles também        ");
                    Console.WriteLine("    encontram uma passagem secreta que leva para fora da floresta.        ");
                    Console.WriteLine("     Os heróis saem da floresta e retornam para a cidade de Valerion,    ");
                    Console.WriteLine("    onde são recebidos como verdadeiros heróis e celebrados por sua       ");
                    Console.WriteLine("    coragem e bravura. O reino de Valerion está seguro graças a eles!     ");
                    Console.WriteLine();
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("||                             FIM DA CAMPANHA!                         ||");
                    Console.WriteLine("==========================================================================");
                    Console.ResetColor();

                    return;
                }

            }




        }

        class Personagem
        {
            // ==================================================
            // Classe Pai (BASE): Personagem
            // ==================================================
            //Esta classe define os atributos e comportamento
            //comuns a QUALQUER personagem do jogo.

            // ENCAPSULAMENTO: os "set" agora são "private set".
            // Isso significa que Nome, Nivel, Vida, Maxvida, poderAtaque e XP
            // só podem ser alterados por código DENTRO da própria classe
            // Personagem (ou de suas classes filhas, através dos métodos
            // públicos como Curar, ReceberDano e GanharXP).
            // Antes, qualquer parte do programa podia fazer, por exemplo,
            // "aragorn.Vida = 99999;" e quebrar todas as regras do jogo.
            // Agora isso não compila mais fora da classe.
            public string Nome { get; private set; }
            public int Nivel { get; private set; }
            public int Vida { get; private set; }
            public int Maxvida { get; private set; }
            public int poderAtaque { get; private set; }
            public int XP { get; private set; }

            public int XPNivel
            {
                get
                {
                    return Nivel * 100;
                }
            }

            // Construtor: agora é a ÚNICA forma de definir os valores
            // iniciais de um Personagem. Ele centraliza a criação e
            // garante que todo Personagem nasce em um estado válido
            // (Vida = Maxvida, XP = 0).
            public Personagem(string nome, int nivel, int vida, int poderAtaque)
            {
                Nome = nome;
                Nivel = nivel;
                Vida = vida;
                Maxvida = vida;
                this.poderAtaque = poderAtaque;
                XP = 0;
            }

            // Método para o personagem se movimentar
            // virtual
            public virtual void Mover()
            {
                Console.WriteLine();
                EscreverNome();
                Console.WriteLine(" está se movendo pelo o Santuário...");

            }
            public virtual void atacar(Personagem alvo)
            {
                EscreverNome();
                Console.Write(" está atacando ");
                alvo.EscreverNome();
                Console.WriteLine();
                alvo.ReceberDano(poderAtaque);
                // fazer outro metodo...
            }
            public void ReceberDano(int dano)
            {
                Vida -= dano;
                if (Vida < 0)
                {
                    Vida = 0;
                }
                EscreverNome();
                Console.WriteLine($" recebeu {dano} de dano! (Vida Atual: {Vida}/{Maxvida} HP)");
                if (Vida == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    EscreverNome();
                    Console.WriteLine($" foi derrotado!");
                    Console.ResetColor();
                }
            }
            // Metodo para verificar se o personagem está vivo

            public bool Estavivo()
            {
                return Vida > 0;
            }

            public int Curar(int pocaodecura)
            {
                Vida += pocaodecura;

                if (Vida > Maxvida)
                {
                    Vida = Maxvida;
                }

                Console.WriteLine();
                EscreverNome();
                Console.WriteLine($" recuperou {pocaodecura} HP! vida atual: {Vida} HP ");
                return Vida;
            }


            public void GanharXP(int quantidade)
            {
                if (quantidade <= 0)
                    return;

                XP += quantidade;

                EscreverNome();
                Console.WriteLine($" recebeu {quantidade} XP!" + $" XP atual: {XP}/{Nivel * 100}");

                VerificarNivel();
            }


            private void VerificarNivel()
            {
                // Exemplo: cada nível requer 100 XP multiplicado pelo nível atual

                while (XP >= XPNivel)
                {
                    XP -= XPNivel;

                    Nivel++;

                    // Aumenta o poder de ataque
                    poderAtaque += 15;

                    // Aumenta a vida maxima
                    Maxvida += 20;

                    // Recupere a vida ao subir de nível
                    Vida = Maxvida;

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;

                    EscreverNome();

                    Console.WriteLine($" Subiu para o nível {Nivel}!");

                    EscreverNome();

                    Console.WriteLine($" Agora possui {poderAtaque} de poder de ataque.");

                    EscreverNome();

                    Console.WriteLine($" Nova vida máxima: {Maxvida} " + $" XP restante: {XP}/{XPNivel}");

                    Console.ResetColor();

                    Console.WriteLine();
                }
            }

            // Sistema de cada personagem tem uma cor
            public void EscreverNome()
            {
                ConsoleColor corOriginal = Console.ForegroundColor;

                switch (Nome)
                {
                    case "Aragorn":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;

                    case "Gadanlf":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case "Raphael":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                    case "Goblin Rei":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Dragão Vermelho":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }

                Console.Write(Nome);
                Console.ForegroundColor = corOriginal;
            }



        }

        // ==================================================
        // 2. Classe filha: Guerreiro
        // ==================================================
        // Herda de Personagem e adiciona caracteristicas exclusivas 
        //(Força da Espada)
        class Guerreiro : Personagem
        {
            // Também encapsulado: só pode ser definido no construtor.
            public int ForcaEspada { get; private set; }

            // Construtor chama o construtor da classe base (Personagem)
            // com "base(...)" e depois define o atributo exclusivo do Guerreiro.
            public Guerreiro(string nome, int nivel, int vida, int poderAtaque, int forcaEspada)
                : base(nome, nivel, vida, poderAtaque)
            {
                ForcaEspada = forcaEspada;
            }

            // Sobreescrever o ataque para usar a espada
            // de forma unica
            public override void atacar(Personagem alvo)
            {
                int danoTotal = poderAtaque + ForcaEspada;
                EscreverNome();
                Console.Write($" (Guerreiro) desfere um golpe no ");
                alvo.EscreverNome();
                Console.WriteLine();
                alvo.ReceberDano(danoTotal);
            }
        }

        // ==================================================
        // 3. Classe filha: Mago
        // ==================================================
        //Herda de Personagem e adiciona a Mana e o sistema
        //de Feitiços
        class Mago : Personagem
        {
            public int Mana { get; private set; }

            public Mago(string nome, int nivel, int vida, int poderAtaque, int mana)
                : base(nome, nivel, vida, poderAtaque)
            {
                Mana = mana;
            }

            public override void atacar(Personagem alvo)
            {
                if (Mana >= 20)
                {
                    Mana -= 20; // Gasta Mana
                    int danoMagico = poderAtaque * 2;
                    EscreverNome();
                    Console.Write($" (Mago) desfere uma Bola de Fogo no ");
                    alvo.EscreverNome();
                    Console.WriteLine($": Mana Restante: {Mana}");
                    alvo.ReceberDano(danoMagico);
                }
                else
                {
                    EscreverNome();
                    Console.WriteLine(" esta sem mana suficiente no seu cajado !!");
                    // Chama o ataque básico do pai 
                    base.atacar(alvo);
                }


            }
        }

        // ==================================================
        // 4. Classe filha: Arqueiro
        // ==================================================
        // Herda de Personagem e adiciona limite de flechas
        // Flecha Poderosa

        class Arqueiro : Personagem
        {
            public int Flechas { get; private set; }

            public Arqueiro(string nome, int nivel, int vida, int poderAtaque, int flechas)
                : base(nome, nivel, vida, poderAtaque)
            {
                Flechas = flechas;
            }

            public override void atacar(Personagem alvo)
            {
                if (Flechas > 0)
                {
                    Flechas -= 1; // Gasta flechas
                    int FlechaPoderosa = poderAtaque + 10;
                    EscreverNome();
                    Console.Write($" (Arqueiro) lança uma flecha poderosa no ");
                    alvo.EscreverNome();
                    Console.WriteLine($": flechas restantes: {Flechas}");
                    alvo.ReceberDano(FlechaPoderosa);

                }
                else
                {
                    // Chama o ataque básico do pai 
                    // usa um ataque extra
                    EscreverNome();
                    Console.Write(" está sem flechas na Aljava! Ele ataca ");
                    alvo.EscreverNome();
                    Console.WriteLine(" com uma adaga oculta.");

                    base.atacar(alvo);
                }
            }
        }

        // Sistema de combate
        // ==================================================

        static class Combate
        {
            static Random random = new Random();

            public static bool Iniciar(List<Personagem> herois, List<Personagem> inimigos, int numeroCombate)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine();
                Console.WriteLine($"=== Heróis se preparando para batalha!! === ");
                Console.WriteLine();
                Console.WriteLine($"====================================== COMBATE {numeroCombate} =======================================");
                Console.ResetColor();

                int turno = 1;

                static int CalcularXP(List<Personagem> inimigos)
                {
                    int xpTotal = 0;

                    foreach (Personagem inimigo in inimigos)
                    {
                        xpTotal += inimigo.Nivel * 25;
                    }

                    return xpTotal;
                }

                while (Existemvivos(herois) && Existemvivos(inimigos))
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"===== TURNO {turno} ==========================================================================");
                    Console.WriteLine();
                    Console.ResetColor();

                    // Turno dos heróis
                    foreach (Personagem heroi in herois)
                    {
                        if (heroi.Estavivo())
                        {
                            Personagem alvo = EncontrarAlvo(inimigos);
                            if (alvo != null)
                            {
                                heroi.atacar(alvo);
                            }
                        }
                    }
                   
                    // verificar se os inimigos foram derrotados antes do turno dos inimigos
                    if (!Existemvivos(inimigos))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                        Console.WriteLine("Os heróis venceram o combate!");
                        Console.ResetColor();

                        // Calcular XP ganho pelos heróis
                        int xpGanho = CalcularXP(inimigos);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Cada herói recebeu {xpGanho} XP!");
                        Console.ResetColor();

                        // Entregar XP aos heróis vivos
                        foreach (Personagem heroi in herois)
                        {
                            if (heroi.Estavivo())
                            {
                                heroi.GanharXP(xpGanho);
                            }
                        }
                        return true;
                    }

                    // Turno dos inimigos
                    foreach (Personagem inimigo in inimigos)
                    {
                        if (inimigo.Estavivo())
                        {
                            Personagem alvo = EncontrarAlvo(herois);
                            if (alvo != null)
                            {
                                inimigo.atacar(alvo);
                            }
                        }
                    }
                    turno++;


                    Console.WriteLine();
                    Console.WriteLine("Pressione ENTER para continuar...");
                    Console.ReadLine();
                }

                return false;
            }

            // Existe algum personagem vivo na lista?

            // ==================================================

            static Personagem EncontrarAlvo(List<Personagem> personagens)
            {

                List<Personagem> vivos = new List<Personagem>();

                foreach (Personagem personagem in personagens)
                {
                    if (personagem.Estavivo())
                    {
                        vivos.Add(personagem);
                    }
                }
                if (vivos.Count == 0)
                {
                    return null;
                }
                return vivos[random.Next(vivos.Count)];
            }
        }
        // Verifica se existem personagens vivos na lista
        static bool Existemvivos(List<Personagem> personagens)
        {
            foreach (Personagem personagem in personagens)
            {
                if (personagem.Estavivo())
                {
                    return true;
                }
            }
            return false;

        }
    }
}

