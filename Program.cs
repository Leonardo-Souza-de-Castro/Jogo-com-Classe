using System;

namespace Exercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = false;
            bool recomecar = false;
            string Escolha_Personagem = "";
            string Escolha_inimigo = "";

            Personagem Player_1 = new Personagem();

            Personagem Player_2 = new Personagem();

            do
            {
                Console.WriteLine($@"
================================
|   Selecione o seu personagem:|
|------------------------------|
|    1 - Capitão América       |
|    2 - Homem Aranha          |
|    3 - Homem de Ferro        |  
================================
");

                Escolha_Personagem = Console.ReadLine();

                switch (Escolha_Personagem)
                {
                    case "1":

                        Player_1.nome = "Capitão América";

                        Player_1.idade = 120;

                        Player_1.armadura = "Escudo";

                        Player_1.ponto_de_vida = 80;
                        Console.WriteLine("Capitão América Selecionado");
                        break;
                    case "2":
                        Player_1.nome = "Homem Aranha";

                        Player_1.idade = 16;

                        Player_1.armadura = "Teia de Aranha";

                        Player_1.ponto_de_vida = 50;
                        Console.WriteLine("Homem Aranha Selecionado");
                        break;
                    case "3":
                        Player_1.nome = "Homem de Ferro";

                        Player_1.idade = 53;

                        Player_1.armadura = "Mark 1";

                        Player_1.ponto_de_vida = 75;
                        Console.WriteLine("Homem de Ferro Selecionado");
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada, selecione um novo jogador");
                        recomecar = true;
                        break;
                }
            } while (recomecar);

            do
            {

                Console.WriteLine($@"
================================
|   Selecione o seu inimigo:   |
|------------------------------|
|    1 - Capitão América       |
|    2 - Homem Aranha          |
|    3 - Homem de Ferro        |  
================================
");

                Escolha_inimigo = Console.ReadLine();

                switch (Escolha_inimigo)
                {
                    case "1":
                        Player_2.nome = "Capitão América";

                        Player_2.idade = 120;

                        Player_2.armadura = "Escudo";

                        Player_2.ponto_de_vida = 80;
                        Console.WriteLine("Capitão América Selecionado");
                        recomecar = false;
                        break;
                    case "2":
                        Player_2.nome = "Homem Aranha";

                        Player_2.idade = 16;

                        Player_2.armadura = "Teia de Aranha";

                        Player_2.ponto_de_vida = 50;
                        Console.WriteLine("Homem Aranha Selecionado");
                        recomecar = false;
                        break;
                    case "3":
                        Player_2.nome = "Homem de Ferro";

                        Player_2.idade = 53;

                        Player_2.armadura = "Mark 1";

                        Player_2.ponto_de_vida = 75;
                        Console.WriteLine("Homem de Ferro Selecionado");
                        recomecar = false;
                        break;
                    default:
                        Console.WriteLine("Opção não encontrada, selecione um novo jogador");
                        recomecar = true;
                        break;
                }

                if (Escolha_inimigo == Escolha_Personagem)
                {
                    Console.WriteLine("Por Favor escolha um personagem que você ainda não escolheu");
                    recomecar = true;
                }
            } while (recomecar);

            do
            {
                
                Console.WriteLine($@"
==============================================
| Player 1 selecione o que você quer fazer:  |
|--------------------------------------------|
|    1 - Atacar                              |
|    2 - Defender                            |
==============================================
            ");
            string resposta_1 = Console.ReadLine();
                
                Console.WriteLine($@"
==============================================
| Player 2 selecione o que você quer fazer:  |
|--------------------------------------------|
|    1 - Atacar                              |
|    2 - Defender                            |
==============================================
            ");
            string resposta_2 = Console.ReadLine();

            if (resposta_1 == "1" && resposta_2 == "1")
            {
                Player_1.ponto_de_vida = Player_1.ponto_de_vida - Player_2.Ataque();
                Player_2.ponto_de_vida = Player_2.ponto_de_vida - Player_1.Ataque();
                Console.WriteLine($"Vida do {Player_1.nome}: {Player_1.ponto_de_vida}");
                Console.WriteLine($"Vida do {Player_2.nome}: {Player_2.ponto_de_vida}");
                if (Player_1.ponto_de_vida >= 0 || Player_2.ponto_de_vida >= 0)
                {
                    repetir = true;
                }
            }
            else if (resposta_1 == "1" && resposta_2 == "2")
            {
                Player_2.ponto_de_vida = Player_2.ponto_de_vida - (Player_1.Ataque() - Player_2.Defender());
                Console.WriteLine($"Vida do {Player_1.nome}: {Player_1.ponto_de_vida}");
                Console.WriteLine($"Vida do {Player_2.nome}: {Player_2.ponto_de_vida}");
                if (Player_1.ponto_de_vida >= 0 || Player_2.ponto_de_vida >= 0)
                {
                    repetir = true;
                }
            }
            else if (resposta_2 == "1" && resposta_1 == "2")
            {
                Player_1.ponto_de_vida = Player_1.ponto_de_vida - (Player_2.Ataque() - Player_1.Defender());
                Console.WriteLine($"Vida do {Player_1.nome}: {Player_1.ponto_de_vida}");
                Console.WriteLine($"Vida do {Player_2.nome}: {Player_2.ponto_de_vida}");
                if (Player_1.ponto_de_vida >= 0 || Player_2.ponto_de_vida >= 0)
                {
                    repetir = true;
                }
            }
            else if (resposta_2 == "2" && resposta_1 == "2")
            {
                Console.WriteLine("Ambos defenderam ninguem perdeu vida");
            }

            } while (repetir);
        }
    }
}
