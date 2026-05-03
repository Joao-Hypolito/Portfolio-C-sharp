using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Heroes
{
    public class Rogue : Character, IAgile
    {
        public Rogue(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, defense, strength, dexterity, knowlegde, wielder)
        {
        }

        public void Dodge() => Console.WriteLine($"{Name} vanished into the shadows and dodged!");

        public override void ReceiveDamage(float damage)
        {
            // Lógica: 30% de chance de esquivar se for um Ladino
            if (new Random().NextDouble() < 0.3)
            {
                Dodge();
                Console.WriteLine($"{Name} suffered no damage!");
            }
            else
            {
                base.ReceiveDamage(damage); // Se falhar, toma o dano normal
            }


        }
    }
}