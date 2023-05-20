using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class AHeroes : ACharacter
    {
        public int victoryPoints = 0; 
        public int VictoryPoints 
        {
            get
            {
                return this.victoryPoints;
            } 
            set
            {
                this.victoryPoints = value;
            }
        }

        public void KillTheEnemy(AVillains enemy)
        {
            if (enemy.Health == 0)
            {
                this.victoryPoints += enemy.VictoryPoints;
            }
        }
    }
}