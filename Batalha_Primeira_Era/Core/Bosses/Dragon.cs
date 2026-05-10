using Batalha_Primeira_Era.Items.Weapons;
using Batalha_Primeira_Era.Items.BossAction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Bosses
{
    public class Dragon : Character
    {
        public Dragon(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, defense, strength, dexterity, knowlegde, wielder)
        {
        }

        public override List<BodyPart> GetTargetTableParts()
        {
            var parts = base.GetTargetTableParts();
            parts.Add(BodyPart.Wings);
            parts.Add(BodyPart.Belly);
            return parts;
        }
        public void LifeMultiplier(Character target)
        {
            lifePont *= 10;
        }

    }
}
