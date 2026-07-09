using System;
using System.Collections.Generic;
using System.Text;

namespace Simulador_Sensores
{
    public class Sensor_Temp : Model
    {
        public double Temperatura { get; set; }
        public Sensor_Temp(double temp)
        {
            Temperatura = temp;
        }

        public override void GerarNovaLeitura()
        {
            Random random = new Random();

            double variacaoTemp = (random.NextDouble() * 2 - 1) * 0.5;
            Temperatura += variacaoTemp;

            if (Temperatura < 25) Temperatura = 25;
            if (Temperatura > 45) Temperatura = 45;

            DataHora = DateTime.Now;


        }
    }
}
