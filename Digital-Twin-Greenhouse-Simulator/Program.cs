namespace Simulador_Sensores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tomate EstufaTomate = new Tomate(25.0, 60.0);
            Laranja EstufaLaranja = new Laranja(35.0, 60.0);


            while (true)
            {
                //-----------------ESTUFA DE TOMATE-----------------

                EstufaTomate.GerarNovaLeitura();
                Console.WriteLine($"Estufa de Tomate: [{EstufaTomate.DataHora}] Temp: {EstufaTomate.Temperatura:F2} Umid: {EstufaTomate.Umidade:F2}");
                System.Threading.Thread.Sleep(2000);

                //-----------------ESTUFA DE LARANJA----------------

                EstufaLaranja.GerarNovaLeitura();
                Console.WriteLine($"\nEstufa de Laranja: [{EstufaLaranja.DataHora}] Temp: {EstufaLaranja.Temperatura:F2} Umid: {EstufaLaranja.Umidade:F2}");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
