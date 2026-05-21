using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Heroes
{
    public class Warrior : Character, IGreat_Sword<Great_Sword>, IGreat_Axe<Great_Axe>, ISword<Sword>, IShield<Shield>
    {
        public Great_Sword equippedGreat_Sword { get; set; }
        public Great_Axe equippedGreat_Axe { get; set; }
        public Sword equippedSword {  get; set; }
        public Shield equippedShield { get; set; }

        public Warrior(string name, float life, int insight, float defense, int strength, int dexterity, int knowlegde, Great_Sword wielder) : 
            base(name, life, insight, defense, strength, dexterity, knowlegde, wielder)
        {
            equippedGreat_Sword = wielder;
        }

        public Warrior(string name, float life, int insight, float defense, int strength, int dexterity, int knowlegde, Great_Axe wielder) :
        base(name, life, insight, defense, strength, dexterity, knowlegde, wielder)
        {
            equippedGreat_Axe = wielder;
        }

        public Warrior(string name, float life, int insight, float defense, int strength, int dexterity, int knowlegde, Sword wielder) :
        base(name, life, insight, defense, strength, dexterity, knowlegde, wielder)
        {
            equippedSword = wielder;
        }

        public Warrior(string name, float life, int insight, float defense, int strength, int dexterity, int knowlegde, Shield wielder) :
        base(name, life, insight, defense, strength, dexterity, knowlegde, wielder)
        {
            equippedShield = wielder;
        }



        public override void ReceiveDamage(float damage, BodyPart hitPart)
        {
            base.ReceiveDamage(damage, hitPart);
        }

    }
}
