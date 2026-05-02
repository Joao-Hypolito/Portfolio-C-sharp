using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Items.Weapons
{
    public class Staff: Weapon
    {
        public Staff(string name, float baseDamage, int reStrength, int reDexterity, int reKnowledge) :
            base(name, baseDamage, reStrength, reDexterity, reKnowledge)
        { }

        public override float CalculateDamage(Batalha_Primeira_Era.Core.Character wielder)
        {
            float finalDamage = this.BaseDamage + (wielder.Knowledge * 1.5f);

            return finalDamage;
        }
    }
}
