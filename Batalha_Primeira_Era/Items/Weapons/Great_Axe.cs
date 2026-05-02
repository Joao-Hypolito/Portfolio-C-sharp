using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Items.Weapons
{
    public class Great_Axe: Weapons
    {
        public Great_Axe(string name, float baseDamage, float weight, int durability, int requiredStrength, int requiredDexterity, float criticalChance, float criticalMultiplier, float armorPenetration, float knockbackForce) : 
            base (name, baseDamage, weight, durability, requiredStrength, requiredDexterity, criticalChance, criticalMultiplier, armorPenetration, knockbackForce) { }

        public override float CalculateDamage(Batalha_Primeira_Era.Core.Character wielder)
        {
            float finalDamage = this.BaseDamage + (wielder.Strength * 1.5f);

            return finalDamage;
        }


    }
}
