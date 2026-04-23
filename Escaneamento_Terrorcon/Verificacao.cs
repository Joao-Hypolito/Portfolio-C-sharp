using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Escaneamento_Terrorcon
{
    public class Verificacao : Veiculo
    {
        int nota = 0;

        public override void VerificarCombustivel()
        {
            Console.WriteLine("Qual o combustivel?");
            string Combustivel = Console.ReadLine();
            if (Combustivel.ToLower() == "energon")
            {
                Console.WriteLine($"ALVO PERFEITO DETECTADO! Combustivel: {Combustivel}");
                nota ++;
            }
            else if(Combustivel.ToLower() == "diesel")
            {
                Console.WriteLine($"ALVO PERFEITO DETECTADO! Combustivel: {Combustivel}");
                nota ++;
            }
            else if(Combustivel.ToLower() == "eletrico")
            {
                Console.WriteLine("Lixo detectado...");
                nota --;
            }
            else
            {
                Console.WriteLine("Veiculo Incompativel!");
            }
        }

        public override void VerificarAno()
        {
            Console.WriteLine("Qual o ano do veiculo?");
            int Ano = int.Parse(Console.ReadLine());

            if(Ano > 2010)
            {
                Console.WriteLine("HARDWARE PERFEITO!");
                nota ++;
            }
            else
            {
                Console.WriteLine("Hardware ultrapassado. Escaneamento abortado!");
            }
        }

        public override void VerificarNota()
        {
            Console.WriteLine("Qual a nota do veiculo de 0 a 10?");
            int Nota = int.Parse(Console.ReadLine());

            if(Nota > 10)
            {
                Nota = 10;
            }
            else
            {
                Nota = Nota;
            }

            if(Nota > 8)
            {
                Console.WriteLine("Veiculo robusto!");
                nota ++;
            }
            else
            {
                Console.WriteLine("Veiculo frágil!");
            }
        }

        public override void MedidaFinal()
        {
            if(nota > 2)
            {
                Console.WriteLine("Veículo robusto. Escaneamento concluído!");
            }
            else
            {
                Console.WriteLine("Nenhum veiculo bom disponivel!");
            }
        }
    }
}