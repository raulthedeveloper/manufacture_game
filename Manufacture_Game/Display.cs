using System;
namespace Manufacture_Game
{

    public class Display
    {

        private Player PlayerData {get; set;}

        public Display(Player player)
        {
            PlayerData = player;
        }

        public void PlayerStats()
        {
            Console.WriteLine($"Company Name: {PlayerData.CompanyName} \nMoney: {PlayerData.Money}");

            this.MainMenu();
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
            DataProcessor BuyPatent = new DataProcessor(PlayerData.Money);
            BuyPatent.BuyPatent();
            this.PlayerStats();
            this.MainMenu();
        }

        public void Manufacture()
        {
            Console.WriteLine("Welcome to buy Manufacture");
            this.MainMenu();
        }

        public void FindProspects()
        {
            Console.WriteLine("Its time to find some business");
            this.MainMenu();
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
                    this.PlayerStats();
                    break;
                default:
                    Console.WriteLine("please select a valid choide");
                    this.MainMenu();
                    break;

            }

        }
    }
}
