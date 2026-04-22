using System;
using System.Collections.Generic;
using System.Text;

namespace Decepticons
{
    public class Constructicons
    {
        public string Nome {  get; set; }
        public string Funcao { get; set;  }
        public Constructicons(string nome, string funcao)
        {
            Nome = nome;
            Funcao = funcao;
        } 
    }
}
