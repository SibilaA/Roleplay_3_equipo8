﻿using System;
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

            //Creo villano.
            AVillains Ganon = new EvilArcher("Ganondorf");

            AVillains Saruman = new EvilWizard("Saruman");

            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");

            Battle LordofRings = new Battle("LordofRings");

            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillains(Ganon);

            LordofRings.AddHeroes(Gandalf);
            LordofRings.AddVillains(Saruman);
;
            //Se pelean.
            firstBattle.CreateBattle();
            
            LordofRings.CreateBattle();



        }
    }
}
