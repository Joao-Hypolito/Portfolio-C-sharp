using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversidade
{
    public class AnimalAquatico : SerVivo
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Esse animal faz um som caracteristico do ambiente aquático");
        }

        public override void Habitat()
        {
            Console.Write("Esse animal pertence ao habitat aquatico");
        }
    }
}
