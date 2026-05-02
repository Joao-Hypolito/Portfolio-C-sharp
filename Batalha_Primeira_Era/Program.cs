using Batalha_Primeira_Era.Core;
using Batalha_Primeira_Era.Items.Weapons;

namespace Batalha_Primeira_Era
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Great_Axe machadoInicial = new Great_Axe("Storm", 50f, 10f, 100, 15, 5, 0.1f, 2.0f, 5f, 20f);

            Warrior hurin = new Warrior("Hurin", 100, 97, machadoInicial);
            Wizard galadriel = new Wizard("Galadriel", 90, 120, machadoInicial);
            Dragon glaurung = new Dragon("Glaurung", 100, 40, machadoInicial);

            glaurung.LifeMultiplier(glaurung);

            hurin.TakeAction(glaurung);
            galadriel.TakeAction(glaurung);

            Console.WriteLine("\n---Enemy's Turn---");

            glaurung.DragonGaze(galadriel);
            glaurung.TakeAction(hurin);

        }
    }
}
