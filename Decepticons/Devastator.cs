using System;
using System.Collections.Generic;
using System.Text;

namespace Decepticons
{
    internal class Devastator
    {
        public string NomeRobo { get; set; }

        public Lideres Chefe { get; set; }

        public List<Constructicons> Membros { get; set; } = new List<Constructicons>();

        public Devastator(string nome, Lideres chefe)
        {
            NomeRobo = nome;
            Chefe = chefe;
            Membros.Add(new Constructicons("Scrapper", "Perna Direita"));
            Membros.Add(new Constructicons("Hook", "Cabeça e a parte superior do tronco/ombros"));
            Membros.Add(new Constructicons("Bonecrusher", "Braço esquerdo"));
            Membros.Add(new Constructicons("Scavenger", "Braço direito"));
            Membros.Add(new Constructicons("Long Haul", "Parte inferior do tronco/cintura"));
            Membros.Add(new Constructicons("Mixmaster", "Perna esquerda"));
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Robô: {NomeRobo} | Liderado por: {Chefe.Nome}");
            Console.WriteLine("Componentes (Constructicons");
            foreach (var c in Membros)
            {
                Console.WriteLine($"- {c.Nome}: {c.Funcao}");
            }
        }
    }
}
