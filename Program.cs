namespace O_Ritual_de_bakbattahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerreiro hurin = new Guerreiro("Hurin", 100);
            Mago galadriel = new Mago("galadriel", 90);

            hurin.RealizarAcao(galadriel);
            galadriel.RealizarAcao(hurin);
            
        }
    }
}
