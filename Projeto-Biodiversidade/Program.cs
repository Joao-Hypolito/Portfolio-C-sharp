namespace Biodiversidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<SerVivo> MeusAnimais = new List<SerVivo>();

            MeusAnimais.Add(new Lobo { Nome = "Robert" });
            MeusAnimais.Add(new Leao { Nome = "Mufasa" });
            MeusAnimais.Add(new Golfinho { Nome = "Jeremy" });

            foreach ( var animal in MeusAnimais)
            {
                animal.ExibirInformacoes();
                animal.EmitirSom();
                animal.Habitat();
                Console.WriteLine("\n---------");
                Console.WriteLine("\n");
            }
        }
    }
}
