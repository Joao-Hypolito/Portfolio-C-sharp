using Batalha_Primeira_Era.Items.Weapons;
using Batalha_Primeira_Era.Items.BossAction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Bosses
{
    public class Dragon : Character
    {
        public Dragon(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, defense, strength, dexterity, knowlegde, wielder)
        {
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
