using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Simulador_Sensores
{
    public abstract class Model
    {
        public DateTime DataHora { get; set; }

        public abstract void GerarNovaLeitura();


    }
}
