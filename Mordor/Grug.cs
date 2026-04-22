using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor
{
    internal class Grug : UnidadeMordor
    {
        public override void ExecutarOrdem()
        {
            Console.WriteLine("Grug tentando processar...");
        }

        public void LobotomiaDactilar()
        {
            Console.WriteLine("Grug cutucou o nariz tão fundo! Que resetou a CPU dele!");
        }

    }
}
