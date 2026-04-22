using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Bancario
{
    public class ContaBancaria
    {
        public string Titular {  get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"\nO deposito de R${valor} foi bem sucedido na conta de {Titular}!");
                Console.WriteLine($"O valor atual da conta é de R${Saldo}");
            }

        }

        public void Sacar(double valor)
        {
            if(valor > 0 && Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"\nO saque do valor R${valor} foi bem sucedido na conta de {Titular}!");
                Console.WriteLine($"O valor restante da conta é de R${Saldo}");
            }
            else
            {
                Console.WriteLine("\nNão será possível realizar o saque!");
            }

        }
    }
}
