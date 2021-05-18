using System;

namespace Exercicio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool recomecar = false;
            string Escolha_Personagem = "";
            string Escolha_inimigo = "";

            Personagem Personagem_1 = new Personagem();

            Personagem_1.nome = "Capitão América";

            Personagem_1.idade = 120;

            Personagem_1.armadura = "Escudo";

            Personagem_1.ponto_de_vida = 80;


            Personagem Personagem_2 = new Personagem();

            Personagem_2.nome = "Homem Aranha";

            Personagem_2.idade = 16;

            Personagem_2.armadura = "Teia de Aranha";

            Personagem_2.ponto_de_vida = 50;


            Personagem Personagem_3 = new Personagem();

            Personagem_3.nome = "Homem de Ferro";

            Personagem_3.idade = 53;

            Personagem_3.armadura = "Mark 1";

            Personagem_3.ponto_de_vida = 75;

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
                        Console.WriteLine("Capitão América Selecionado");
                        break;
                    case "2":
                        Console.WriteLine("Homem Aranha Selecionado");
                        break;
                    case "3":
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
                        Console.WriteLine("Capitão América Selecionado");
                        recomecar = false;
                        break;
                    case "2":
                        Console.WriteLine("Homem Aranha Selecionado");
                        recomecar = false;
                        break;
                    case "3":
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

            Console.WriteLine($@"
=====================================
|   Selecione o que você quer fazer:|
|-----------------------------------|
|    1 - Atacar                     |
|    2 - Defender                   |
=====================================
            ");
            string acao = Console.ReadLine();

            if (Escolha_Personagem == "1")
            {
                
            }

        }
    }
}
