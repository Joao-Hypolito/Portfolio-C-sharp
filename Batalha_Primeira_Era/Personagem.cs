using System;
using System.Collections.Generic;
using System.Text;

namespace O_Ritual_de_bakbattahl
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int PontoDeVida { get; protected set; }

        public int Dano { get; set; }

        public Personagem(string nome, int vida, int dano) 
        {
         Nome = nome;
         PontoDeVida = vida;
         Dano = dano;
        }

        public abstract void RealizarAcao(Personagem alvo);

        public void ReceberDano(int dano)
        {
            PontoDeVida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano! Vida restante: {PontoDeVida}");
        }

        public void MultiplicadorDeVida(Personagem alvo)
        {
            PontoDeVida *= 10;
        }

        public int PartesDoDragao(Personagem alvo)
        {
            int danoFinal = this.Dano;

            Random random = new Random();
            int Sorteio = random.Next(1, 101);

            if (Sorteio <= 50)
            {
                danoFinal = Dano * 1;
                Console.WriteLine($"\n{Nome} acertou a escama do {alvo.Nome}!!!");
            }
            else if (Sorteio <= 70)
            {
                danoFinal = Dano * 2;
                Console.WriteLine($"\n{Nome} acertou o pescoco do {alvo.Nome}!!!");
            }
            else if (Sorteio <= 90)
            {
                danoFinal = Dano * 5;
                Console.WriteLine($"\n{Nome} acertou a cabeca do {alvo.Nome}!!!");
            }
            else
            {
                danoFinal = Dano * 8;
                Console.WriteLine($"\n {Nome} acertou o ventre do {alvo.Nome}!!!");
            }
            return danoFinal;
        }
        public void OlharDoDragao(Personagem alvo)
        {

            Random random = new Random();

            bool sorteio = random.Next(2) == 1;

            if (sorteio)
            {
                Console.WriteLine($"\n{alvo.Nome} Está aterrorizado");
            }
            else
            {
                Console.WriteLine($"\n{alvo.Nome} Resistiu ao olhar do {this.Nome}!");
            }
        }

    }
}
