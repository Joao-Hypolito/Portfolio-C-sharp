using System;
using System.Collections.Generic;

namespace Decepticons
{
    public class EsquadraoSeeker
    {
        public string Nome { get; set; }
        public Lideres Chefe { get; set; } 

        public List<EsquadraoSeeker> Soldados { get; set; } = new List<EsquadraoSeeker>();

        public EsquadraoSeeker(string nome)
        {
            Nome = nome;
        }

        public void DefinirChefe(Lideres novoChefe)
        {
            Chefe = novoChefe;
        }

        public void AdicionarSoldado(EsquadraoSeeker soldado)
        {
            Soldados.Add(soldado);
        }

        public void MostrarRelatorio()
        {
            Console.WriteLine($"\n--- ESQUADRÃO: {Nome} ---");
            Console.WriteLine($"Comandante: {(Chefe != null ? Chefe.Nome : "Sem comando")}");
            Console.WriteLine("Membros em formação de voo:");
            foreach (var s in Soldados)
            {
                Console.WriteLine($"- Jet: {s.Nome}");
            }
        }
    }
}