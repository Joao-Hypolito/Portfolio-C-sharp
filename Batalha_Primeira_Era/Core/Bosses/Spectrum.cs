using Batalha_Primeira_Era.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Batalha_Primeira_Era.Core.Bosses
{
    public class Spectrum : Character, IDiscernment
    {
        public Spectrum(string name, float life, int insight, float defense, int strength, int dexterity, int knowledge, Weapon wielder)
            : base(name, life, insight, defense, strength, dexterity, knowledge, wielder)
        {
        }

        public void LifeMultiplier(Character target)
        {
            lifePont *= 5;
        }

        public void Wraiths()
        {
            Console.WriteLine($"\nO véu da realidade se rasga. {Name} clama pelas forças do Mundo Invisível...");
        }

        // Retorna TRUE se o herói pode atacar, ou FALSE se o Spectrum bloquear e quebrar a arma dele
        public bool DefendAgainstAttacker(Character attacker)
        {
            // Cenário: Discernimento baixo (Menor que 40) -> BLOQUEIA E QUEBRA A ARMA
            if (attacker.SpectralInsight < 40)
            {
                Console.WriteLine($"\n==================================================");
                Console.WriteLine($"{attacker.Name} tenta golpear {Name}, mas seus olhos não conseguem focar no plano espectral!");
                Console.WriteLine($"{Name} ergue a mão de ferro e profere uma ordem direta na mente de {attacker.Name}:");
                Console.WriteLine($"— \"QUEBRE...\"");
                Console.WriteLine($"==================================================");

                if (attacker.EquippedWeapon != null)
                {
                    Console.WriteLine($"A aura negra estala! A arma {attacker.EquippedWeapon.Name} perde o brilho e QUEBRA totalmente!");
                    
                    // 1. Primeiro a propriedade Durability da sua classe Weapon zera o item!
                    attacker.EquippedWeapon.Durability = 0f; 

                    // 2. AGORA PRINTA! Puxa direto da arma para provar na tela que ela está zerada!
                    Console.WriteLine($"Estado do Item: {attacker.EquippedWeapon.Name} | Durabilidade Atual: {attacker.EquippedWeapon.Durability} (TRAVADA EM ZERO!)");
                }

                Console.WriteLine($"{attacker.Name} errou o ataque e ficou em choque!");
                return false; // Retorna false: o ataque foi cancelado!
            }

            // Cenário: Discernimento alto (40 ou mais) -> BOSS FIGHT NORMAL
            Console.WriteLine($"\n{attacker.Name} resiste à aura de {Name} com {attacker.SpectralInsight} de Discernimento! A batalha continua!");
            return true; // Retorna true: pode desferir o golpe!
        }

        // O método recebe o Herói (target) que está tentando atacar o Spectrum
        public void CommandOfRuina(Character target)
        {
            int insightDifference = this.SpectralInsight - target.SpectralInsight;

            Console.WriteLine($"\n==================================================");
            Console.WriteLine($"{Name} ergue a mão de ferro. O ar fica gélido.");
            Console.WriteLine($"Uma voz absoluta esmaga a sua mente:");
            Console.WriteLine($"— \"QUEBRE...\"");
            Console.WriteLine($"==================================================");

            // Cenário 1: Discernimento do jogador é muito baixo!
            if (insightDifference > 40)
            {
                if (target.EquippedWeapon != null)
                {
                    Console.WriteLine($"Sua vontade é INSIGNIFICANTE perante {Name}!");
                    Console.WriteLine($"A {target.EquippedWeapon.Name} explode em mil pedaços nas suas mãos!");
                    target.EquippedWeapon = null; // A arma do jogador vira poeira!
                }
            }
            // Cenário 2: Discernimento parecido (Briga de vontades!)
            else if (insightDifference <= 40 && insightDifference > 0)
            {
                Console.WriteLine($"Você sente uma pressão colossal estraçalhando sua mente, mas sua visão do além te sustenta!");
                Console.WriteLine($"Você trinca os dentes, segura a {target.EquippedWeapon.Name} com força e COMPEDE contra a vontade do monstro!");
                Console.WriteLine($"A arma racha, mas resiste inteira! A batalha continua!");
            }
            // Cenário 3: O jogador transcendeu!
            else
            {
                Console.WriteLine($"O comando de {Name} ecoa como um sussurro ridículo na sua mente.");
                Console.WriteLine($"Sua vontade é tão vasta quanto o próprio Mundo Invisível. Você olha nos olhos do espectro e não cede um milímetro!");
                Console.WriteLine($"— \"Não aqui...\" você responde. O feitiço dele se volta contra ele mesmo!");
            }
        }

    }
}