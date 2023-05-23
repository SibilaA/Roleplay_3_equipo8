using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: AHeroes
    {

        public Dwarf(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }

    }
}