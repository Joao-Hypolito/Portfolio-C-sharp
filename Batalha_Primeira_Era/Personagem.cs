using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int PontoDeVida { get; protected set; }

        public Personagem(string nome, int vida) 
        {
         Nome = nome;
         PontoDeVida = vida;
        }

        public abstract void RealizarAcao(Personagem alvo);

        public void ReceberDano(int dano)
        {
            PontoDeVida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida restante: {PontoDeVida}");
        }

        public void MultiplicadorDeVida(Personagem alvo)
        {
            PontoDeVida *= 10;
        }

        public void OlharDoDragao(Personagem alvo)
        {

            Random random = new Random();

            bool sorteio = random.Next(2) == 1;

            if (sorteio)
            {
                Console.WriteLine($"\n{alvo.Nome} Está aterrorizado");
            }
            else
            {
                Console.WriteLine($"\n{alvo.Nome} Resistiu ao olhar do {this.Nome}!");
            }
        }

    }
}
