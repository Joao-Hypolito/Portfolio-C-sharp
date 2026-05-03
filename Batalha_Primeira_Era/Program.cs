using Batalha_Primeira_Era.Items.Weapons;
using Batalha_Primeira_Era.Items.BossAction.DragonAtack;
using Batalha_Primeira_Era.Core.Bosses;
using Batalha_Primeira_Era.Core.Heroes;

namespace Batalha_Primeira_Era
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dagger sting = new Dagger("Sting", 97f, 10, 10, 10);
            Staff staffinitial = new Staff("Staff", 80f, 10, 9, 30);
            Grazing GrazingDragon = new Grazing("Grazing", 80f, 10, 9, 30);
            DragonGaze Gaze = new DragonGaze("Glaurung", 0f, 0, 0, 0);

            Rogue frodo = new Rogue("Frodo", 100f, 100, 40, 23, 15, sting);
            Wizard galadriel = new Wizard("Galadriel", 90f, 70, 14, 17, 57, staffinitial);
            Dragon glaurung = new Dragon("Glaurung", 100f, 80, 50, 30, 40, Gaze);

            glaurung.LifeMultiplier(glaurung);

            frodo.TakeAction(glaurung);
            galadriel.TakeAction(glaurung);

            Console.WriteLine("\n---Enemy's Turn---");

            Gaze.Dragongaze(galadriel);
            glaurung.TakeAction(frodo);

        }
    }
}
