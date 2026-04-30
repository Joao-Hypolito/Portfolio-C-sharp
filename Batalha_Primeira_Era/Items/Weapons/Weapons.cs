using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl.Items.Weapons
{
    public abstract class Weapons
    {
        public float BaseDamage { get; set; }
        
        public float Weight { get; set; }

        public int Durability { get; set; }

        public int RequiredStrength { get; set; }

        public int RequiredDexterity { get; set; }

        public float CriticalChance { get; set; }

        public float CriticalMultiplier {  get; set; }

        public float ArmorPenetration { get; set; }

        public float KnockbackForce { get; set; }

        public Weapons(float baseDamage, float weight, int durability, int requiredStrength, int requiredDexterity, float criticalChance, float criticalMultiplier, float armorPenetration, float knockbackForce)
        {
            BaseDamage = baseDamage;
            Weight = weight;
            Durability = durability;
            RequiredStrength = requiredStrength;
            RequiredDexterity = requiredDexterity;
            CriticalChance = criticalChance;
            CriticalMultiplier = criticalMultiplier;
            ArmorPenetration = armorPenetration;
            KnockbackForce = knockbackForce;
        }
    }
}
