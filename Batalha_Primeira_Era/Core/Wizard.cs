using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl.Character
{
    public class Wizard : Character
    {
        public Wizard(string name, float life, float damage) : base(name, life, damage)
        {
        }

        public override void TakeAction(Character target)
        {
            float MagicAtack = DragonParts(target);
            Console.WriteLine($"Wizard {Name} attacks with his magic!");
            target.ReceiveDamage(MagicAtack);
        }

    }
}
