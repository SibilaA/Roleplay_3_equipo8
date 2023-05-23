using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: AHeroes
    {
        public Knight(string name)
        {
            this.Name = name;
            this.health = 100;

            
            this.AddItem(new Sword());
            this.AddItem(new Shield());
            this.VictoryPoints = 1;

        }
    }
}