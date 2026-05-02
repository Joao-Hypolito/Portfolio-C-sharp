using Batalha_Primeira_Era.Core;
using Batalha_Primeira_Era.Items.Weapons;
using Batalha_Primeira_Era.Items.BossAction.DragonAtack;

namespace Batalha_Primeira_Era
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Great_Axe axelinitial = new Great_Axe("Storm", 97f, 10, 10, 10);
            Staff staffinitial = new Staff("Staff", 80f, 10, 9, 30);
            Grazing GrazingDragon = new Grazing("Grazing", 80f, 10, 9, 30);
            DragonGaze Gaze = new DragonGaze("Glaurung", 0f, 0, 0, 0);

            Warrior hurin = new Warrior("Hurin", 100f, 40, 23, 15, axelinitial);
            Wizard galadriel = new Wizard("Galadriel", 90f, 14, 17, 57, staffinitial);
            Dragon glaurung = new Dragon("Glaurung", 100f, 50, 30, 40, Gaze);

            glaurung.LifeMultiplier(glaurung);

            hurin.TakeAction(glaurung);
            galadriel.TakeAction(glaurung);

            Console.WriteLine("\n---Enemy's Turn---");

            Gaze.Dragongaze(galadriel);
            glaurung.TakeAction(hurin);

        }
    }
}
