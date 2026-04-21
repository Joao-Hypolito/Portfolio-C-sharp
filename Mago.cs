using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl
{
    public class Mago : Personagem
    {
        public Mago(string nome, int vida) : base(nome, vida)
        {
        }

        public override void RealizarAcao(Personagem alvo)
        {
            int danoMagico = 25;
            Console.WriteLine($"Mago {Nome} ataca com seu magia!");
            alvo.ReceberDano(danoMagico);
        }

    }
}
