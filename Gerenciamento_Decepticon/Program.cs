namespace Gerenciamento_Decepticon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decepticon nemesis = new Decepticon("Nemesis Prime", 160, "Caminhão", false);
            Decepticon blitzwing = new Decepticon("Blitzwing", 40, "jato", true);

            nemesis.Transformar(nemesis);
            blitzwing.Transformar(blitzwing);

            Console.WriteLine($"O Blitzwing vai trair agora? {blitzwing.PlanoDeTraicao}");
        }
    }
}
