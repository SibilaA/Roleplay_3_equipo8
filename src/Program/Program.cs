using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo héroe.
            AHeroes Link = new Archer("Link");

            AHeroes Gandalf = new Wizard("Gandalf");

            AHeroes Arturo = new Knight("Arturo");

            //Creo villano.
            AVillains Ganon = new EvilArcher("Ganondorf");

            AVillains Saruman = new EvilWizard("Saruman");

            AVillains Surtur = new EvilKnight("Surtur");

            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");

            Battle LordofRings = new Battle("LordofRings");

            Battle Ragnarok = new Battle("Ragnarok");

            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillains(Ganon);

            LordofRings.AddHeroes(Gandalf);
            LordofRings.AddVillains(Saruman);

            Ragnarok.AddHeroes(Arturo);
            Ragnarok.AddVillains(Surtur);

;
            //Se pelean.
            firstBattle.CreateBattle();
            
            LordofRings.CreateBattle();

            Ragnarok.CreateBattle();

            



        }
    }
}
