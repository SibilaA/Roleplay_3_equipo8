using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: AHeroes, IMagicCharacter
    {
       private List<IMagicalItem> magicalItem = new List<IMagicalItem>();
       public Wizard(string name)
        {
            this.Name = name;
            this.health = 100;
            
            this.AddItem(new Staff());

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