using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl.Character
{
    public class Dragon : Character
    {
        public Dragon(string name, float life, float damage) : base(name, life, damage)
        {
        }


        public override void TakeAction(Character target)
        {
            float AtackDamage = this.Damage;

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
