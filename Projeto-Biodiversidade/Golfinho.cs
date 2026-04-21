using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversidade
{
    internal class Golfinho : AnimalAquatico
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} faz um som agradável e meigo!");
        }

        public override void Habitat()
        {
            base.Habitat();
        }
    }
}
