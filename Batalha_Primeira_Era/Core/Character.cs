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
        public float Strength { get; set; }
        public Weapons EquippedWeapon { get; set; }

        public Character(string name, float life, float strength, Weapons wielder) 
        {
         Name = name;
         lifePont = life;
         Strength = strength;
         EquippedWeapon = wielder;
        }

        public abstract void TakeAction (Character target);

        public void ReceiveDamage(float amount)
        {
            lifePont -= amount;
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
        public void DragonGaze(Character target)
        {

            Random random = new Random();

            bool Raffle = random.Next(2) == 1;

            if (Raffle)
            {
                Console.WriteLine($"\n{target.Name} is terrified");
            }
            else
            {
                Console.WriteLine($"\n{target.Name} resisted the gaze of {this.Name}!");
            }
        }

    }
}
