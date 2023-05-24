using System.Collections.Generic;

namespace RoleplayGame
{
    public class EvilDwarf : AVillains
    {
        public EvilDwarf(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Axe());
            this.AddItem(new Armor());
            this.VictoryPoints = 2;
        }
    }
}