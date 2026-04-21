using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversidade
{
    internal class Leao : AnimalTerrestre
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} solta um rugido que faz a savana tremer!!!");
        }

        public override void Habitat()
        {
            base.Habitat();
        }
    }
}
