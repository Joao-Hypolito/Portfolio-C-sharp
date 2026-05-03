using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Items.Weapons
{
    public class Dagger : Weapon
    {
        public Dagger(string name, float baseDamage, int reStrength, int reDexterity, int reKnowledge) :
            base(name, baseDamage, reStrength, reDexterity, reKnowledge)
        { }

        public override float CalculateDamage(Batalha_Primeira_Era.Core.Character wielder)
        {
            float variation = new Random().Next(90, 110) / 100f;
            return (BaseDamage + (wielder.Strength * 1.5f)) * variation;
        }


    }
}
