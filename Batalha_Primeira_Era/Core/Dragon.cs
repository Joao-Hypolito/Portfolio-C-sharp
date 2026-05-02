using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core
{
    public class Dragon : Character
    {
        public Dragon(string name, float life, float strength, Weapons wielder) : base(name, life, strength, wielder)
        {
        }


        public override void TakeAction(Character target)
        {
            float AtackDamage = this.Strength;

            Random random = new Random();

            bool Raffle = random.Next(2) == 1;

            if (Raffle)
            {
                Console.WriteLine($"\nDragon {target.Name} attacks with its flames!");
                target.ReceiveDamage(AtackDamage);
            }
            else
            {
                Console.WriteLine($"\nDragon missed the attack on {target.Name}!");
            }
        }
    }
}
