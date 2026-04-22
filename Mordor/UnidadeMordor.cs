using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor
{
    public abstract class UnidadeMordor
    {
        public string Nome { get; set; }

        public abstract void ExecutarOrdem();

        public void RelatarStatus()
        {
            Console.WriteLine($"Unidade {Nome} aguardando Olho");
        }

    }
}
