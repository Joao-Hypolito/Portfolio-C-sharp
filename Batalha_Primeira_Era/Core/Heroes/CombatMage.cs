using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Heroes
{
    public class CombatMage : Character, IGreat_Sword<Great_Sword>, ISword<Sword>
    {
        public Great_Sword equippedGreat_Sword { get; set;}
        public Sword equippedSword { get; set;}

        public CombatMage(string name, float life, int insight, float defense, int strength, int dexterity, int knowlegde, Great_Sword wielder) : 
            base(name, life, insight, defense, strength, dexterity, knowlegde, wielder)
        {
            equippedGreat_Sword = wielder;
        }

        public CombatMage(string name, float life, int insight, float defense, int strength, int dexterity, int knowlegde, Sword wielder) :
        base(name, life, insight, defense, strength, dexterity, knowlegde, wielder)
        {
            equippedSword = wielder;
        }

        public override void ReceiveDamage(float damage, BodyPart hitPart)
        {
            base.ReceiveDamage(damage, hitPart);
        }
    }
}
