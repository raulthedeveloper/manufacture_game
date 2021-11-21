using System;
namespace Manufacture_Game
{
    public class Player
    {
        private string _companyName;
        private int _money;
        private int _experiencePoints;

        public string CompanyName
        {
            get { return _companyName; }
        }

        public int Money
        {
            get { return _money; }

            set { _money = value; }
        }

        public int ExperiencePoint
        {
            get { return _experiencePoints; }

            set { _experiencePoints = ExperiencePoint; }
        }


        public Player(string CompanyName, int Money, int ExperiencePoints)
        {
            _companyName = CompanyName;
            _money = Money;
            _experiencePoints = ExperiencePoints;
        }
    }
}
