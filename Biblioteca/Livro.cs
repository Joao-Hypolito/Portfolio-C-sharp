using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public int AnoPublicado { get; set; }

        public List<Autor> Autores { get; set; } = new List<Autor>();

        public Livro(string titulo, int ano)
        {
            Titulo = titulo;
            AnoPublicado = ano;
        }

        public void AdicionarAutor(Autor autor)
        {
            Autores.Add(autor);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Livro: {Titulo} ({AnoPublicado})");
            Console.WriteLine("Autores:");
            foreach (var a in Autores)
            {
                Console.WriteLine($"- {a.Nome} ({a.Email})");
            }
        }
    }
}
