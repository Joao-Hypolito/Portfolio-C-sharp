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
            Great_Sword morgul = new Great_Sword("Morgul", 50f, 30, 25, 56);
            Grazing GrazingDragon = new Grazing("Grazing", 80f, 10, 9, 30);
            DragonGaze Gaze = new DragonGaze("Dragon Gaze", 0f, 0, 0, 0);
            Bow Bow = new Bow("Bow", 67f, 20, 40, 20);

            Rogue frodo = new Rogue("Frodo", 100f, 60, 20, 40, 50, 15, sting);
            Archer legolas = new Archer("Legolas", 87f, 60, 20, 40, 50, 15, sting);
            Wizard galadriel = new Wizard("Galadriel", 90f, 70, 70, 14, 17, 57, staffinitial);
            Dragon glaurung = new Dragon("Glaurung", 100f, 78, 80, 50, 30, 40, Gaze);
            Spectrum nazgul = new Spectrum("Agnmar", 100f, 78, 80, 45, 78, 67, morgul);

            glaurung.LifeMultiplier(glaurung);
            nazgul.LifeMultiplier(nazgul);

            frodo.TakeAction(glaurung);
            legolas.TakeAction(glaurung);
            if (nazgul.DefendAgainstAttacker(frodo))
            {
                frodo.TakeAction(nazgul);
            }  

            Console.WriteLine("\n---Enemy's Turn---");

            Gaze.Dragongaze(galadriel);
            nazgul.TakeAction(frodo);

        }
    }
}
