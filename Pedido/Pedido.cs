using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido
{
    public class Pedido
    {
        public int Numero {  get; set; }
        public Cliente Cliente { get; set; }

        public List<ItemPedido> Itens { get; } = new();

        public void AdicionarItem(string nome, double preco)
        {
            Itens.Add(new ItemPedido { Produto = nome, Preco = preco });
        }

        public void Resumo()
        {
            Console.WriteLine($"---Pedido Nº:{Numero}---");
            Console.WriteLine($"Cliente: {Cliente.Nome}");
            Console.WriteLine("itens Pedidos:");
            foreach (var n in Itens)
            {
                Console.WriteLine($"- {n.Produto}: R$ {n.Preco}");
            }
        }
    }

}
