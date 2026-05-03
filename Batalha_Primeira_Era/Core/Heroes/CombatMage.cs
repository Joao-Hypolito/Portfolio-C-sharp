using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Heroes
{
    public class CombatMage : Character, Imagic, IMelee
    {
        public CombatMage(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, defense, strength, dexterity, knowlegde, wielder)
        {
        }

        public void CastSpell()
        {

        }

        public void melee()
        {

        }
    }
}
