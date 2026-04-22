using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Inventario_RPG
{
    public class Mochila
    {
        public double CapacidadeMaxima { get; set; }


        public Mochila(double capacidadeMaxima)
        {
            CapacidadeMaxima = capacidadeMaxima;
        }

        public List<Item> Mapa {  get; set; } = new List<Item>();

        public void AdicionarItem(Item novoItem)
        {
            double pesoTotalAtual = 0;
            foreach (var item in Mapa)
            {
                pesoTotalAtual += item.Peso;
            }

            double pesoDisponivel = CapacidadeMaxima - pesoTotalAtual;

            if(novoItem.Peso > pesoDisponivel)
            {
                Console.WriteLine($"Erro! O item '{novoItem.Nome}' pesa {novoItem.Peso}kg.");
                Console.WriteLine($"Capacidade insuficiente. Espaço disponível: {pesoDisponivel}kg.");
            }
            else
            {
                Mapa.Add(novoItem);
                Console.WriteLine($"Sucesso: '{novoItem.Nome}' guardado!");
                double sobraFinal = CapacidadeMaxima - (pesoTotalAtual + novoItem.Peso);
                Console.WriteLine($"Espaço restante na mochila: {sobraFinal}kg");
            }

        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n---Itens No Inventario---");
            foreach (var s in Mapa)
            {
                Console.WriteLine($"-{s.Nome} (Peso: {s.Peso}Kg)");
            }
        }
    }
}


