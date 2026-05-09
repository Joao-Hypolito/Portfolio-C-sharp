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
    public interface ITheft
    {
        void Theft();
    }

    public interface IDamageable
    {
        void ReceiveDamage(float damage, Character.BodyPart randomPart); // Tornar tangivel a dano qualquer tipo de alvo
        string Name { get; } // Para poder usar o nome no console
    }
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
        void Melee(); // Habilidade corpo a corpo
    }

    public interface IRanged
    {
        void Ranged(); // Habilidade de Disparo
    }

    public interface IHeavy_Sword
    {
        void HeavySword(); // Habilidade de usar armas de duas mãos
    }

    public interface IShield
    {
        void Shield(); // Habilidade de usar escudo
    }

    public abstract class Character : IDamageable
    {
        public string Name { get; set; }
        public float lifePont { get; protected set; }
        public float Armor { get; set; }
        public int Strength { get; set; }
        public int Dexterity {  get; set; }
        public int Knowledge { get; set; }
        public Weapon EquippedWeapon { get; set; }

        public Character(string name, float life, float defense, int strength, int dexterity, int knowlegde, Weapon wielder) 
        {
            Name = name;
            lifePont = life;
            Armor = defense;
            Strength = strength;
            Dexterity = dexterity;
            Knowledge = knowlegde;
            EquippedWeapon = wielder;
        }

        //Uma lista de palavras que valem números, util para aliviar a memória e impede erros
        public enum BodyPart { Head, Torso, Legs, Arms, Wings}

        /// <summary>
        /// Um método publico (define uma acao publica), o parâmetro indica que o método espera receber um do tipo Personagem.
        /// </summary>
        /// <param name="target">O personagem que receberá o ataque.</param>
        public void TakeAction (IDamageable target)
        {
            Random rng = new Random();

            //Pega todos os nomes da lista BodyPart e joga num "saco"
            Array values = Enum.GetValues(typeof(BodyPart));

            //Pega o valor que está naquela posicao que está no "saco"
            BodyPart randomPart = (BodyPart)values.GetValue(new Random().Next(values.Length));

            if (EquippedWeapon != null)
            {
                if (EquippedWeapon.IsBroken)
                {
                    Console.WriteLine($"{Name} tried to attack, but the weapon broke! Damage reduced.");
                }
                else
                {
                    //Ele delega a responsabilidade do calculo para o objeto(EquippedWeapon). O uso do "this" passa o personagem atual para a arma.
                    float rawDamage = EquippedWeapon.CalculateDamage(this);

                    //Depois do Feedback do sistema (A interface), ele chama o "ReceiveDamage" do alvo, passando o valor calculado anteriormente.
                    Console.WriteLine($"\n{Name} attacks {target.Name} with {EquippedWeapon.Name}!");
                    Console.WriteLine($"Part of the body affected: {randomPart}");
                    target.ReceiveDamage(rawDamage, randomPart);
                }
            }
        }

        /// <summary>
        /// Processa o dano recebido pelo personagem, aplicando reduções baseadas na armadura.
        /// </summary>
        /// <param name="target">O personagem que receberá o ataque.</param>
        public virtual void ReceiveDamage(float damage, BodyPart hitPart)
        {
            //Adiciona um multiplicador com base em qual parte do corpo for atingida
            float multiplier = GetDamageMultiplier(hitPart);
            //Aplica a "Redução de Dano", a armadura do personagem anula o dano na proporção de 50% do valor de armadura
            float damageAfterDefense = (damage * multiplier) - (this.Armor / 2);

            //Garante que o dano nunca seja negativo, sem isso, se a sua armadura fosse muito alta, você seria curado ao levar um golpe
            if (damageAfterDefense < 0) damageAfterDefense = 0;

            Console.WriteLine($"{Name}'s initial lifespan was {lifePont}");

            //A execucao final atualiza o atributo de vida do Personagem com o valor mitigado
            lifePont -= damageAfterDefense;
            Console.WriteLine($"{Name} took {damageAfterDefense:F1} damage.");
            Console.WriteLine($"{Name}'s final lifespan is {lifePont}");
        }

        //uso de private é para garantir:
        //O multiplicador seja uma regra interna inviolavel
        //A classe Character é a única que precisa saber como converter a parte do corpo em um multiplicador de dano
        //Facil manutencao futura ou alteracao de valores de multiplicacao
        private float GetDamageMultiplier(BodyPart part)
        {
            return part switch
            {
                BodyPart.Head => 2.0f,
                BodyPart.Torso => 1.0f,
                BodyPart.Wings => 1.5f,
                BodyPart.Arms => 0.8f,
                BodyPart.Legs => 0.8f,
            };
        }

    }
}
