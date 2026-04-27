using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era
{
    public class Guerreiro: Personagem
    {
        public Guerreiro(string nome, int vida, int dano) : base(nome, vida, dano)
        {
        }

        public override void RealizarAcao(Personagem alvo)
        {
            int danoDeAtaque = PartesDoDragao(alvo);
            Console.WriteLine($"Guerreiro {Nome} ataca com seu montante!");
            alvo.ReceberDano(danoDeAtaque);
        }
    }
}
