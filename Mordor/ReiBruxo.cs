using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor
{
    internal class ReiBruxo : UnidadeMordor
    {
        public override void ExecutarOrdem()
        {
            Console.WriteLine("O Rei Bruxo está em modo ocioso (Fazendo nada) e enchendo o saco do Grug");
        }

        public void InfernizarGrug()
        {
            Console.WriteLine("Grug seu incopetente!");
        }
    }
}
