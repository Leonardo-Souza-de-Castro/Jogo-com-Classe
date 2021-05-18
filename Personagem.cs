using System;

namespace Exercicio_POO
{
    public class Personagem
    {
        public string nome;

        public int idade;

        public string armadura;

        public int ponto_de_vida;

        Random ataque = new Random();
        Random defesa = new Random();

        public int Ataque(){
            int Ataque = ataque.Next(15);
            return Ataque;
        }

        public int Defender(){
            int Defesa = defesa.Next(10);
            return Defesa;
        }
    }
}