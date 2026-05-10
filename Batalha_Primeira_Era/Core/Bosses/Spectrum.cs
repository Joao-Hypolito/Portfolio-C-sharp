using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Bosses
{
    public class Spectrum : Character
    {
        public Spectrum(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) : base(name, life, defense, strength, dexterity, knowlegde, wielder)
        {
        }

        public void LifeMultiplier(Character target)
        {
            lifePont *= 5;
        }


    }
}
