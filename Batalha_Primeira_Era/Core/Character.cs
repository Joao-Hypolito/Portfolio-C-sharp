using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Batalha_Primeira_Era.Core
{
    // ============================================================
    // CONTRATOS (Interfaces): O que o personagem PODE FAZER
    // ============================================================
    public interface IAgile
    {
        void Dodge(); // Habilidade de Esquiva
    }

    public interface Imagic
    {
        void CastSpell(); // Habilidade Mágica
    }

    public interface IMelee
    {
        void melee(); // Habilidade corpo a corpo
    }

    public interface IRanged
    {
        void ranged(); // Habilidade de Disparo
    }
    public abstract class Character
    {
        public string Name { get; set; }
        public float lifePont { get; protected set; }
        public float Defense { get; set; }
        public int Strength { get; set; }
        public int Dexterity {  get; set; }
        public int Knowledge { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Character(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) 
        {
            Name = name;
            lifePont = life;
            Defense = defense;
            Strength = strength;
            Dexterity = dexterity;
            Knowledge = knowlegde;
            EquippedWeapon = wielder;
        }

        public void TakeAction (Character target)
        {
            float finalDamage = EquippedWeapon.CalculateDamage(this);
            Console.WriteLine($"\n{Name} attacks {target.Name} with {EquippedWeapon.Name}!");
            target.ReceiveDamage(finalDamage);
        }

        public virtual void ReceiveDamage(float damage)
        {
            float damageAfterDefense = damage - (this.Defense / 2);
            if (damageAfterDefense < 0) damageAfterDefense = 0;


            Console.WriteLine($"{Name}'s initial lifespan was {lifePont}");
            lifePont -= damageAfterDefense;
            Console.WriteLine($"{Name} took {damageAfterDefense:F1} damage.");
            Console.WriteLine($"{Name}'s final lifespan is {lifePont}");
        }

    }
}
