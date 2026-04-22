namespace Mordor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UnidadeMordor> AnimaisDeMordor = new List<UnidadeMordor>();

            AnimaisDeMordor.Add(new ReiBruxo { Nome = "Rei Bruo" });
            AnimaisDeMordor.Add(new Grug { Nome = "Grug" });

            foreach (var animal in AnimaisDeMordor)
            {
                animal.ExecutarOrdem();

                if (animal is ReiBruxo rei)
                {
                    rei.InfernizarGrug(); 
                }

                
                if (animal is Grug grugUnidade)
                {
                    grugUnidade.LobotomiaDactilar();
                }
            }

        }

    }
}
