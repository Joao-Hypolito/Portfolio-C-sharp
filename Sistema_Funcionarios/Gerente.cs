using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Funcionarios
{
    public class Gerente: Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {
            return Salario * 0.2;
        }
    }
}
