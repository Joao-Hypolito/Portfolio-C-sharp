using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    class Circulo : Forma
    {
        public float Raio { get ; set; }

        public Circulo(float raio)
        {
            this.Raio = raio;
        }

        public override float CalcularArea()
        {
            return (float)Math.PI * Raio * Raio;
        }

        public override float CalcularPerimetro()
        {
            return 2 * (float)Math.PI * Raio;
        }
    }
}
