using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl.Character
{
    public class Warrior: Character
    {
        public Warrior(string name, float life, float damage) : base(name, life, damage)
        {
        }

        public override void TakeAction(Character target)
        {
            float AtackDamage = DragonParts(target);
            Console.WriteLine($"Warrior {Name} attacks with his sword!");
            target.ReceiveDamage(AtackDamage);
        }
    }
}
