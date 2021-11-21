using System;
namespace Manufacture_Game
{ 

    public class Display
    {
      

        public Display()
        {
        }

        public void PlayerStats()
        {
            Console.WriteLine("Display players stats");
        }

        public void Greeting(string CompanyName)
        {
            Console.WriteLine($"Welcome to Manufacture Simulation {CompanyName}");
        }

        public void MainMenu()
        {
            Console.WriteLine();

            Console.WriteLine($"1.Buy Patents \n2.Manufacture \n3.Find Prospects\n4 View Stats [type the number]");

            string Choice = Console.ReadLine();

            this.Decision(Choice);
        }

        public void BuyPatents()
        {
            Console.WriteLine("Welcome to buy patents");
        }

        public void Manufacture()
        {
            Console.WriteLine("Welcome to buy Manufacture");
        }

        public void FindProspects()
        {
            Console.WriteLine("Its time to find some business");
        }

        public void ViewStats(int Money, int Level, int ExperiencePoints)
        {
            Console.WriteLine();
            //Console.WriteLine($"Money:{Money} || Level:{Level} || Experience Point: {ExperiencePoints}");
        }

        public void Decision(string Choice)
        {
            // Manages descriptions
            switch(Choice)
            {
                case "1":
                    this.BuyPatents();
                    break;
                case "2":
                    this.Manufacture();
                    break;
                case "3":
                    this.FindProspects();
                    break;
                case "4":
                    Console.WriteLine("This is for View States");
                    break;
                default:
                    Console.WriteLine("please select a valid choide");
                    this.MainMenu();
                    break;

            }

        }
    }
}
