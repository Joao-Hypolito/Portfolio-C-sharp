using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core
{
    public class Warrior: Character
    {
        public Warrior(string name, float life, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, strength, dexterity, knowlegde, wielder)
        {
        }

    }
}
