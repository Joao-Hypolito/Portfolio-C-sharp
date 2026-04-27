namespace O_Ritual_de_bakbattahl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerreiro hurin = new Guerreiro("Hurin", 100, 97);
            Mago galadriel = new Mago("Galadriel", 90, 120);
            Dragao glaurung = new Dragao("Glaurung", 100, 40);

            glaurung.MultiplicadorDeVida(glaurung);

            hurin.RealizarAcao(glaurung);
            galadriel.RealizarAcao(glaurung);

            Console.WriteLine("\n---Turno do Inimigo---");

            glaurung.OlharDoDragao(galadriel);
            glaurung.RealizarAcao(hurin);

        }
    }
}
