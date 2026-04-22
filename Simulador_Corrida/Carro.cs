using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador_Corrida
{
    public class Carro: veiculo
    {
        public Carro(string modelo) : base(modelo)
        {
        }

        public override string Mover()
        {
            return "Andando a 120 Km/h";
        }
    }
}
