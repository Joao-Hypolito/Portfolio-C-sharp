using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Simulador_Sensores
{
    public class Sensor_Umi : Model
    {
                public double Umidade { get; set; }
        public Sensor_Umi ( double umid)
        {
            Umidade = umid;
        }

        public override void GerarNovaLeitura()
        {
            Random random = new Random();

            double variacaoUmid = (random.NextDouble() * 2 - 1) * 1.0;
            Umidade += variacaoUmid;

            if (Umidade < 40) Umidade = 40;
            if (Umidade > 80) Umidade = 80;

            DataHora = DateTime.Now;

        }
    }
}
