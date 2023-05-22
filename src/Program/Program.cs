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

            AHeroes John = new Dwarf("John");

            AHeroes Arturo = new Knight("Arturo");


            //Creo villano.
            AVillains Ganon = new EvilArcher("Ganondorf");

            AVillains Saruman = new EvilWizard("Saruman");

            AVillains Surtur = new EvilWizard("Surtur");

            AVillains Heracles = new EvilDwarf("Heracles");






            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");

            Battle LordofRings = new Battle("LordofRings");

            Battle Ragnarok = new Battle("Ragnarok");

            Battle Coliseo = new Battle("Coliseo");


            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillains(Ganon);

            LordofRings.AddHeroes(Gandalf);
            LordofRings.AddVillains(Saruman);

            Ragnarok.AddHeroes(Arturo);
            Ragnarok.AddVillains(Surtur);

            Coliseo.AddHeroes(John);
            Coliseo.AddVillains(Heracles);


            //Se pelean.
            firstBattle.CreateBattle();
            
            LordofRings.CreateBattle();

            Ragnarok.CreateBattle();

            Coliseo.CreateBattle();

            



        }
    }
}
