using System;
namespace Manufacture_Game
{
    public class Player
    {

        public string CompanyName { get; set; }

        public int Money { get; set; }

        public int ExperiencePoint { get; set; }

        public object[] Inventory { get; set; }

        public int Level
        {
            get
            {
                //complutes player experience to level
                return this.ExperiencePoint;
            }

            set
            {
                Level = value;
            }

     
        }


        public Player(string Name, int PlayerMoney, int PlayerExperiencePoints)
        {
            CompanyName = Name;
            Money = PlayerMoney;
            ExperiencePoint = PlayerExperiencePoints;
        }

        
    }
}
