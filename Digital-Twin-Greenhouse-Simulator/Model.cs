using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Simulador_Sensores
{
    public  class Model
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

        public void GerarNovaLeitura()
        {
            Random random = new Random();

            double variacaoTemp = (random.NextDouble()* 2 - 1) * 0.5;
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
