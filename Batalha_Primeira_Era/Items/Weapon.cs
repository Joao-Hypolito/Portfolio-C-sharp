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
        private float _durability = 100f; 
        public float Durability
        {
            get { return _durability; }
            set
            {
                
                if (value > 100) _durability = 100;
                else if (value < 0) _durability = 0;
                else _durability = value;
            }
        }
        public bool IsBroken => Durability <= 0;


        public Weapon(string name, float baseDamage, int reStrength, int reDexterity, int reKnowledge )
        {
            Name = name;
            BaseDamage = baseDamage;
            RequiredStrength = reStrength;
            RequiredDexterity = reDexterity;
            RequiredKnowledge = reKnowledge;
        }
        public abstract float CalculateDamage(Batalha_Primeira_Era.Core.Character wielder);

        public void Use()
        {
            if (Durability > 0)
            {
                Durability -= 0.25f;
                if (Durability < 0) Durability = 0;
            }
        }
        public float CurrentDamage
        {
            get
            {
                if (Durability == 0) return 0;
                if (Durability < 30) return BaseDamage * 0.7f; // Dano reduzido por cansaço
                return BaseDamage;
            }
        }

    }
}

