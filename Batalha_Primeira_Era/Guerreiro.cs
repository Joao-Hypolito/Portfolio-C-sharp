using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl
{
    public class Guerreiro: Personagem
    {
        public Guerreiro(string nome, int vida) : base(nome, vida)
        {
        }

        public override void RealizarAcao(Personagem alvo)
        {
            int danoDeAtaque = 97;
            Console.WriteLine($"\nGuerreiro {Nome} ataca com seu montante!");
            alvo.ReceberDano(danoDeAtaque);
        }
    }
}
