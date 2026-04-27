using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl
{
    public class Dragao : Personagem
    {
        public Dragao(string nome, int vida, int dano) : base(nome, vida, dano){}


        public override void RealizarAcao(Personagem alvo)
        {
            int danoDeAtaque = this.Dano;

            Random random = new Random();

            bool sorteio = random.Next(2) == 1;

            if (sorteio)
            {
                Console.WriteLine($"\nDragão {alvo.Nome} ataca com suas chamas!");
                alvo.ReceberDano(danoDeAtaque);
            }
            else
            {
                Console.WriteLine($"\nDragão errou o ataque em {alvo.Nome}!");
            }
        }
    }
}
