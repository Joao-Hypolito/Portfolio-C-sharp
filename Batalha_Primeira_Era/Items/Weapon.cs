using System;
using System.Collections.Generic;
using System.Text;
using Batalha_Primeira_Era.Core;
using static Batalha_Primeira_Era.Core.Character;

namespace Batalha_Primeira_Era.Items.Weapons
{
    public abstract class Weapon
    {
        public string Name { get; set; }
        public float BaseDamage { get; set; }
        public int RequiredStrength { get; set; }
        public int RequiredDexterity { get; set; }
        public int RequiredKnowledge { get; set; }


        public Weapon(string name, float baseDamage, int reStrength, int reDexterity, int reKnowledge)
        {
            Name = name;
            BaseDamage = baseDamage;
            RequiredStrength = reStrength;
            RequiredDexterity = reDexterity;
            RequiredKnowledge = reKnowledge;
        }
        public abstract float CalculateDamage(Batalha_Primeira_Era.Core.Character wielder);

    }
}

