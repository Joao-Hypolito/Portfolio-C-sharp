using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core
{
    public class Wizard : Character
    {
        public Wizard(string name, float life, float strength, Weapons wielder) : base(name, life, strength, wielder)
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
