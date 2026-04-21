using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversidade
{
    public class AnimalTerrestre : SerVivo
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Esse animal faz um som caracteristico do ambiente terrestre");
        }

        public override void Habitat()
        {
            Console.Write("Esse animal pertence ao habitat terrestre");
        }
    }
}
