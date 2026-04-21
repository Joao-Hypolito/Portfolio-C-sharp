using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversidade
{
    public abstract class SerVivo
    {
        public string Nome { get; set;  }

        public abstract void EmitirSom();

        public abstract void Habitat();

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome: " + Nome);
        }


    }
}
