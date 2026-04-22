using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    class Retangulo : Forma
    {
        public float Lado { get; set; }
        public float Altura { get; set; }

        public Retangulo(float Lado, float Altura)
        {
            this.Lado = Lado;
            this.Altura = Altura;
        }

        public override float CalcularArea()
        {
            return Lado * Altura;
        }

        public override float CalcularPerimetro()
        {
            return 2 * (Lado +  Altura);
        }
    }
}
