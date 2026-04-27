using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era
{
    public class Mago : Personagem
    {
        public Mago(string nome, int vida, int dano) : base(nome, vida, dano)
        {
        }

        public override void RealizarAcao(Personagem alvo)
        {
            int danoMagico = PartesDoDragao(alvo);
            Console.WriteLine($"Mago {Nome} ataca com seu magia!");
            alvo.ReceberDano(danoMagico);
        }

    }
}
