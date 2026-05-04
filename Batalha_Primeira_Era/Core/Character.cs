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

        /// <summary>
        /// Um método publico (define uma acao publica), o parâmetro indica que o método espera receber um do tipo Personagem.
        /// </summary>
        /// <param name="target">O personagem que receberá o ataque.</param>
        public void TakeAction (Character target)
        {
            //Ele delega a responsabilidade do calculo para o objeto(EquippedWeapon). O uso do "this" passa o personagem atual para a arma.
            float finalDamage = EquippedWeapon.CalculateDamage(this);

            //Depois do Feedback do sistema (A interface), ele chama o "ReceiveDamage" do alvo, passando o valor calculado anteriormente.
            Console.WriteLine($"\n{Name} attacks {target.Name} with {EquippedWeapon.Name}!");
            target.ReceiveDamage(finalDamage);
        }

        /// <summary>
        /// Processa o dano recebido pelo personagem, aplicando reduções baseadas na defesa.
        /// </summary>
        /// <param name="target">O personagem que receberá o ataque.</param>
        public virtual void ReceiveDamage(float damage)
        {
            //Aplica a "Redução de Dano", a defesa do personagem anula o dano na proporção de 50% do valor de Defesa
            float damageAfterDefense = damage - (this.Defense / 2);

            //Garante que o dano nunca seja negativo, sem isso, se a sua defesa fosse muito alta, você seria curado ao levar um golpe
            if (damageAfterDefense < 0) damageAfterDefense = 0;

            Console.WriteLine($"{Name}'s initial lifespan was {lifePont}");

            //A execucao final atualiza o atributo de vida do Personagem com o valor mitigado
            lifePont -= damageAfterDefense;
            Console.WriteLine($"{Name} took {damageAfterDefense:F1} damage.");
            Console.WriteLine($"{Name}'s final lifespan is {lifePont}");
        }

    }
}
