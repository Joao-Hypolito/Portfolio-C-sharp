namespace Simulador_Corrida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<veiculo> ListaVeiculos = new List<veiculo>();

            ListaVeiculos.Add(new Carro("Uno 2007"));
            ListaVeiculos.Add(new Aviao("McDonnell Phantom"));

            foreach (var f in ListaVeiculos)
            {

                Console.WriteLine($"O nome do veiculo é {f.Modelo}");
                Console.WriteLine($"O som que ele emite é: {f.Buzinar()}");
                Console.WriteLine($"A sua velocidade é de: {f.Mover()}");

            }
        }
    }
}
