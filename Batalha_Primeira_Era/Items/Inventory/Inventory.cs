using System;
using System.Collections.Generic;
using System.Text;
using Batalha_Primeira_Era.Items.Weapons;

namespace Batalha_Primeira_Era.Items.Inventory
{
    public class Inventory
    {
        private List<Weapon> _slots;
        public int MaxCapacity { get; set; }

        public Inventory(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
            _slots = new List<Weapon>();
        }

        public void Additem(Weapon item)
        {
            if(_slots.Count >= MaxCapacity) 
            {
                Console.WriteLine("Inventory is full!");
                return;
            }
            _slots.Add(item);
            Console.WriteLine($"{item.Name} added to inventory.");
        }

        public void ShowInventory()
        {
            Console.WriteLine("\n--- Current Inventory ---");
            foreach (var item in _slots) 
            {
                Console.WriteLine($"- {item.Name} | Damage: {item.CurrentDamage}");
            }
            Console.WriteLine("-------------------------\n");
        }
    }
}