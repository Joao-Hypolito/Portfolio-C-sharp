using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Heroes
{
    public class Warrior : Character, IMelee, IGreat_Sword, IHeavy_Sword, IShield
    {
        public Warrior(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, defense, strength, dexterity, knowlegde, wielder)
        {
        }

        public void Melee()
        {

        }

        public void GreatSword()
        {

        }

        public void HeavySword()
        {

        }

        public void Shield()
        {

        }

    }
}
