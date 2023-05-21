using System.Collections.Generic;

namespace RoleplayGame
{
    public class EvilArcher : AVillains
    {
        public EvilArcher(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
            this.VictoryPoints = 1;
        }
    }
}