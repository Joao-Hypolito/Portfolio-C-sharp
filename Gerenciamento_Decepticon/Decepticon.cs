using System;
using System.Collections.Generic;
using System.Text;

namespace Gerenciamento_Decepticon
{
    public class Decepticon: Transformer
    {
        public bool PlanoDeTraicao {  get; set; }
        public Decepticon(string nome, int energon, string modAlternativo, bool traicao): base (nome, energon, modAlternativo)
        { 
            PlanoDeTraicao = traicao;
        }

        public override void Transformar(Transformer Escolhido)
        {
            ExibirStatus(Escolhido);
            Console.WriteLine($"Se transformou! Em {ModoAlternativo}");
            Console.ReadLine();
        }
    }
}
