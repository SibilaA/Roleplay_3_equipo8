using System.Collections.Generic;
using System;
namespace RoleplayGame
{
    public class Battle
    {
        public string BattleName {get;set;}
        public List<AHeroes> Heroes = new List<AHeroes>();
        public List<AVillains> Villains = new List<AVillains>();
        public Battle (string battleName)
        {
            this.BattleName = battleName;
        }
        public void AddHeroes(AHeroes pj)
        {
            Heroes.Add(pj);
        }
        public void AddVillains(AVillains pj)
        {
            Villains.Add(pj);
        }
        public void CreateBattle()
        {
            int countH = 0;
            int countV = 0;
            var listH = Heroes;
            var listV = Villains;
            while (listH.Count >= 1 && listV.Count >= 1)
            {
                listH[countH].ReceiveAttack(listV[countV].AttackValue);
                if (listH[countH].Health == 0)
                {
                    listH.Remove(listH[countH]);
                }
                else
                {
                    countH += 1;
                }
                if (countH > listH.Count-1)
                {
                    countH = 0;
                }
                
                if (listH.Count > 0)
                {
                    listV[countV].ReceiveAttack(listH[countH].AttackValue);
                    listH[countH].KillTheEnemy(listV[countV]);
                    if (listH[countH].VictoryPoints == 5)
                    {
                        listH[countH].Cure();
                    }
                    if (listV[countV].Health == 0)
                    {
                        listV.Remove(listV[countV]);
                    }
                    else
                    {
                        countV += 1;
                    }
                    if (countV > listV.Count-1)
                    {
                        countV = 0;
                    }
                }
            }

            if (listH.Count >= 1)
            {
                foreach (AHeroes H in listH)
                {
                    Console.WriteLine(H.Name);
                    Console.WriteLine(H.VictoryPoints);
                }
            }
            if (listV.Count >= 1)
            {
                foreach (AVillains V in listV)
                {
                    Console.WriteLine(V.Name);
                }
            }
        }
    }
}