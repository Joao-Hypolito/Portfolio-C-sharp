namespace Simulador_Sensores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Model> listaSensores = new List<Model> 
            {
                new Sensor_Umi(25.0),
                new Sensor_Temp(60.0)
            };

            Dictionary<Model, double> somas = new Dictionary<Model, double>();
            Dictionary<Model, int> contadores = new Dictionary<Model, int>();

            foreach(var sensor in listaSensores) 
            {
                somas[sensor] = 0;
                contadores[sensor] = 0;
            }

            while(true)
            {
                foreach(var sensor in listaSensores)
                {
                    sensor.GerarNovaLeitura();
                    double valorAtual = sensor is Sensor_Umi u ? u.Umidade : ((Sensor_Temp)sensor).Temperatura;
                    string tipoSensor = sensor is Sensor_Umi ? "Umidade" : "Temperatura";
                    string unidadeMedida = sensor is Sensor_Umi ? "%" : "°C";

                    somas[sensor] += valorAtual;
                    contadores[sensor]++;
                
                    if(contadores[sensor] == 5)
                    {
                        double media = somas[sensor] / 5;
                        Console.WriteLine($"\n Sensor de {tipoSensor}: [{sensor.DataHora}] | Média: {media:F2}{unidadeMedida}");
                        
                        somas[sensor] = 0;
                        contadores[sensor] = 0;
                    }
                }
                
                System.Threading.Thread.Sleep(250);
            }
        }
    }
}
