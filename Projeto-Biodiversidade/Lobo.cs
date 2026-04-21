using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversidade
{
    internal class Lobo : AnimalTerrestre
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} Emite um grunhido que congela o coracao de quem ouve");
        }

        public override void Habitat()
        {
            Console.WriteLine($"{Nome} Vive numa caverna assustadora!!!");
        }
    }
}
