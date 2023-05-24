using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo héroe.
            /*

            AHeroes Link = new Archer("Link");

            AHeroes Gandalf = new Wizard("Gandalf");

            AHeroes John = new Dwarf("John");

            AHeroes Arturo = new Knight("Arturo");


            //Creo villano.
            AVillains Ganon = new EvilArcher("Ganondorf");

            AVillains Saruman = new EvilWizard("Saruman");

            AVillains Surtur = new EvilKnight("Surtur");

            AVillains Heracles = new EvilDwarf("Heracles");






            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");

            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillains(Ganon);

            firstBattle.AddHeroes(Gandalf);
            firstBattle.AddVillains(Saruman);


            firstBattle.AddHeroes(Arturo);
            firstBattle.AddVillains(Surtur);

            firstBattle.AddHeroes(John);
            firstBattle.AddVillains(Heracles);


            //Se pelean.
            firstBattle.CreateBattle();
            
            */

            AHeroes John = new Dwarf("John");
            AHeroes Arturo = new Knight("Arturo");
            AVillains Ganon = new EvilArcher("Ganondorf");
            AVillains Surtur = new EvilKnight("Surtur");
            Battle firstBattle = new Battle("First Battle.");
            firstBattle.AddHeroes(John);
            firstBattle.AddHeroes(Arturo);
            firstBattle.AddVillains(Ganon);
            firstBattle.AddVillains(Surtur);
            firstBattle.CreateBattle();
            



            

        }
    }
}
