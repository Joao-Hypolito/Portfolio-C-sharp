using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl.Character
{
    public abstract class Character
    {
        public string Name { get; set; }
        public float lifePont { get; protected set; }
        public float Damage { get; set; }

        public Character(string name, float life, float damage) 
        {
         Name = name;
         lifePont = life;
         Damage = damage;
        }

        public abstract void TakeAction (Character target);

        public void ReceiveDamage(float damage)
        {
            lifePont -= damage;
            Console.WriteLine($"{Name} received {damage} damage! Life remaining: {lifePont}");
        }

        public void LifeMultiplier(Character target)
        {
            lifePont *= 10;
        }

        public float DragonParts(Character target)
        {
            float Finaldam = this.Damage;

            Random random = new Random();
            int Raffle = random.Next(1, 101);

            if (Raffle <= 50)
            {
                Finaldam = Damage * 1;
                Console.WriteLine($"\n{Name} hit the {target.Name} scale right!!!");
            }
            else if (Raffle <= 70)
            {
                Finaldam = Damage * 2;
                Console.WriteLine($"\n{Name} hit {target.Name} in the neck!!!");
            }
            else if (Raffle <= 90)
            {
                Finaldam = Damage * 5;
                Console.WriteLine($"\n{Name} hit {target.Name} in the head!!!");
            }
            else
            {
                Finaldam = Damage * 8;
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
