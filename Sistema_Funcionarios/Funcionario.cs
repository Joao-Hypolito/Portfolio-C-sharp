using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome {  get; set; }
        public double Salario { get; set; }

        public Funcionario (string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public virtual double CalcularBonus() { 
        
        return Salario * 0.1;
        }
    }
}
