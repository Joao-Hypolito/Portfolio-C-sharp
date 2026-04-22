using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante
{
    public class Pedido
    {
        public int Numero { get; set; }
        private List<ItemPedido> _itens = new List<ItemPedido>();

        public Pedido(int numero)
        {
            Numero = numero;
        }

        public void AdicionarItem(string nome, double preco, int qtd)
        {
            ItemPedido novoItem = new ItemPedido(nome, preco, qtd);
            _itens.Add(novoItem);
        }

        public double CalcularTotalPedido()
        {
            double total = 0;
            foreach (var item in _itens)
            {
                total += item.CalcularTotal();
            }
            return total;
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"PEDIDO Nº: {Numero}");
            foreach (var i in _itens)
            {
                Console.WriteLine($"{i.Quantidade}x {i.Nome} - R$ {i.Preco} (Subtotal: R$ {i.CalcularTotal()})");
            }
            Console.WriteLine($"TOTAL FINAL: R$ {CalcularTotalPedido()}");
        }
    }
}
