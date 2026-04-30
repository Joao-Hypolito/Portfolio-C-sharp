using O_Ritual_de_bakbattahl.Character;

namespace Batalha_Primeira_Era
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior hurin = new Warrior("Hurin", 100, 97);
            Wizard galadriel = new Wizard("Galadriel", 90, 120);
            Dragon glaurung = new Dragon("Glaurung", 100, 40);

            glaurung.LifeMultiplier(glaurung);

            hurin.TakeAction(glaurung);
            galadriel.TakeAction(glaurung);

            Console.WriteLine("\n---Enemy's Turn---");

            glaurung.DragonGaze(galadriel);
            glaurung.TakeAction(hurin);

        }
    }
}
