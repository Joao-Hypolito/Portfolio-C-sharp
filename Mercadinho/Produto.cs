using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Produto: {Nome.PadRight(15)} | Preco: {Preco:F2}");
        }

        public void AplicarDesconto(double porcentagem)
        {
            Preco -= Preco * (porcentagem / 100);
        }
    }
}
