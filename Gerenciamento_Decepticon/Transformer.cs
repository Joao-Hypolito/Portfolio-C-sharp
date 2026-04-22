using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Decepticon
{
    public abstract class Transformer
    {
        public string Nome { get; set; }

        private int _NivelEnergon;
        public int NivelEnergon
        {
            get { return _NivelEnergon; }
            set
            {
                if (value < 0) _NivelEnergon = 0;
                else if (value > 100) _NivelEnergon = 100;
                else _NivelEnergon = value;
            }
        }
        public string ModoAlternativo { get; set; }

        public Transformer(string nome, int energon, string modAlternativo)
        {
            Nome = nome;
            NivelEnergon = energon;
            ModoAlternativo = modAlternativo;
        }

        public abstract void Transformar(Transformer Escolhido);

        public void ExibirStatus(Transformer Escolhido)
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Nivel do Energon: {NivelEnergon}");
            Console.WriteLine($"Modo Alternativo: {ModoAlternativo}");
        }
    }
}