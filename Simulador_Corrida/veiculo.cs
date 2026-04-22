using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador_Corrida
{
    public abstract class veiculo
    {
        public string Modelo {  get; set; }

        public veiculo(string modelo) { Modelo = modelo; }

        public abstract string Mover();

        public virtual string Buzinar() 
        {
            return "Bibi";
        }

    }
}
