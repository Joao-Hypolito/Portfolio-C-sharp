using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core
{
    public abstract class Character
    {
        public string Name { get; set; }
        public float lifePont { get; protected set; }
        public int Strength { get; set; }
        public int Dexterity {  get; set; }
        public int Knowledge { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Character(string name, float life, int strength, int dexterity, int knowlegde, Weapon wielder) 
        {
            Name = name;
            lifePont = life;
            Strength = strength;
            Dexterity = dexterity;
            Knowledge = knowlegde;
            EquippedWeapon = wielder;
        }

        public void TakeAction (Character target)
        {
            float finalDamage = EquippedWeapon.CalculateDamage(this);
            target.ReceiveDamage(finalDamage);
            Console.WriteLine($"{Name} attacks {target.Name} with {EquippedWeapon.Name}!");
            Console.WriteLine($"{target.Name} took {finalDamage} damage.");
        }

        public void ReceiveDamage(float amount)
        {
            lifePont -= amount;
            if (lifePont < 0) lifePont = 0;
            Console.WriteLine($"{Name} received {amount} damage! Life remaining: {lifePont}");
        }

        public void LifeMultiplier(Character target)
        {
            lifePont *= 10;
        }

        public float DragonParts(Character target)
        {
            float Finaldam = this.Strength;

            Random random = new Random();
            int Raffle = random.Next(1, 101);

            if (Raffle <= 50)
            {
                Finaldam = Strength * 1;
                Console.WriteLine($"\n{Name} hit the {target.Name} scale right!!!");
            }
            else if (Raffle <= 70)
            {
                Finaldam = Strength * 2;
                Console.WriteLine($"\n{Name} hit {target.Name} in the neck!!!");
            }
            else if (Raffle <= 90)
            {
                Finaldam = Strength * 5;
                Console.WriteLine($"\n{Name} hit {target.Name} in the head!!!");
            }
            else
            {
                Finaldam = Strength * 8;
                Console.WriteLine($"\n {Name} hit {target.Name} in the stomach!!!");
            }
            return Finaldam;
        }

    }
}
