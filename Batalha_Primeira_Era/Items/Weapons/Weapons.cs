using System;
using System.Collections.Generic;
using System.Text;
using Batalha_Primeira_Era.Core;
using static Batalha_Primeira_Era.Core.Character;

namespace Batalha_Primeira_Era.Items.Weapons
{
    public abstract class Weapons
    {
        public string Name { get; set; }
        public float BaseDamage { get; set; }
        
        public float Weight { get; set; }

        public int Durability { get; set; }

        public int RequiredStrength { get; set; }

        public int RequiredDexterity { get; set; }

        public float CriticalChance { get; set; }

        public float CriticalMultiplier {  get; set; }

        public float ArmorPenetration { get; set; }

        public float KnockbackForce { get; set; }

        public Weapons(string name, float baseDamage, float weight, int durability, int requiredStrength, int requiredDexterity, float criticalChance, float criticalMultiplier, float armorPenetration, float knockbackForce)
        {
            Name = name;
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
        public abstract float CalculateDamage(Batalha_Primeira_Era.Core.Character wielder);

    }
}
