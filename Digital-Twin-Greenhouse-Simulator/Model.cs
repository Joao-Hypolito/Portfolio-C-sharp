using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Simulador_Sensores
{
    public abstract class Model
    {
        public double Temperatura { get; set; }

        public double Umidade { get; set; }
        public DateTime DataHora { get; set; }

        public bool Atuador { get; set; }

        public Model (double temp, double umid)
        {
            Temperatura = temp;
            Umidade = umid;
            Atuador = false;
        }

        public abstract void GerarNovaLeitura();

        public bool GetStatusAtuadores(double limite)
        {
            return Temperatura > limite;
        }

        public void SimuladorRuido()
        {

            Temperatura = 999.9;
            DataHora = DateTime.Now;

            Atuador = GetStatusAtuadores(28.0);
            Console.WriteLine("!!! RUIDO INSERIDO NO SISTEMA !!!");
        }


    }
}
