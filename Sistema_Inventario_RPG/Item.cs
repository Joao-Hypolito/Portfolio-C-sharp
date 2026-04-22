using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Inventario_RPG
{
    public class Item
    {
        public string Nome { get; set; }
        public double Peso { get; set; }


        public Item(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }
    }
}
