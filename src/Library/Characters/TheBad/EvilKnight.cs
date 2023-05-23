using System.Collections.Generic;

namespace RoleplayGame
{
    public class EvilKnight : AVillains
    {
        public EvilKnight(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Sword());
            this.AddItem(new Shield());
        }
    }
}