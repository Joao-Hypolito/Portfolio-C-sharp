using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Simulador_Sensores
{
    public class Tomate : Model
    {
        public Tomate (double temp, double umid) : base (temp, umid)
        {

        }

        public override void GerarNovaLeitura()
        {
            Random random = new Random();

            double variacaoTemp = (random.NextDouble() * 2 - 1) * 0.5;
            Temperatura += variacaoTemp;

            if (Temperatura < 15) Temperatura = 15;
            if (Temperatura > 35) Temperatura = 35;

            double variacaoUmid = (random.NextDouble() * 2 - 1) * 1.0;
            Umidade += variacaoUmid;

            if (Umidade < 40) Umidade = 40;
            if (Umidade > 80) Umidade = 80;

            DataHora = DateTime.Now;

            Atuador = GetStatusAtuadores(28.0);

        }
    }
}
