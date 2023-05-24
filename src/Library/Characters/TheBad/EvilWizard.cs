using System.Collections.Generic;

namespace RoleplayGame
{
    public class EvilWizard : AVillains , IMagicCharacter
    {   
        private List<IMagicalItem> magicalItem = new List<IMagicalItem>();
        public EvilWizard(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Staff());
            this.VictoryPoints = 3;
            
        }

        public void AddItem(IMagicalItem item)
        {
            this.magicalItem.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItem.Remove(item);
        }    

    }
}