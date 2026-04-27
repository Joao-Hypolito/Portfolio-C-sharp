namespace Simulador_Sensores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model minhaEstufa = new Model(25.0, 60.0);

            Random rng = new Random();

            while (true)
            {
                if(rng.Next(0,100) < 5)
                {
                    minhaEstufa.SimuladorRuido();
                }
                else
                {
                    minhaEstufa.GerarNovaLeitura();
                }

                Console.WriteLine($"[{minhaEstufa.DataHora}] Temp: {minhaEstufa.Temperatura:F2} Umid: {minhaEstufa.Umidade:F2}  {(minhaEstufa.Atuador ? "LIGADO" : "DESLIGADO")}");

                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
