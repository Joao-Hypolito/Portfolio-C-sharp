using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core
{
    public class Warrior: Character
    {
        public Warrior(string name, float life, float strength, Weapons wielder) : base(name, life, strength, wielder)
        {
        }

        public override void TakeAction(Character target)
        {
            float AtackDamage =  EquippedWeapon.CalculateDamage(this);
            AtackDamage = DragonParts(target);
            Console.WriteLine($"Warrior {Name} attacks with his {EquippedWeapon.Name}!");
            target.ReceiveDamage(AtackDamage);
        }
    }
}
