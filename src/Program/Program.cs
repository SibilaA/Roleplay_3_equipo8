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

            //Creo villano.
            AVillains Ganon = new EvilArcher("Ganondorf");

            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");

            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillains(Ganon);

            //Se pelean.
            firstBattle.CreateBattle();



        }
    }
}
