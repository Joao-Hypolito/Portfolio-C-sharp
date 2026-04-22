using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador_Corrida
{
    public class Aviao: veiculo
    {
        public Aviao(string modelo) : base(modelo)
        {
        }

        public override string Mover()
        {
            return "Decolando a 900 km/h";
        }

        public override string Buzinar()
        {
            return "PUUUIIIIIIIIT";
        }
    }
}
