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
            Console.WriteLine("Diplay players stats");
        }

        public void Greeting(string CompanyName)
        {
            Console.WriteLine($"Welcome to Manufacture Simulation {CompanyName}");
        }

        public void MainMenu()
        {
            Console.WriteLine($" 1.Buy Patents \n 2.Manufacture \n 3.Find Prospects");

            string choice = Console.ReadLine();

            this.Decision(choice);
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

        public void Decision(string choice)
        {
            // Manages descriptions
        }
    }
}
