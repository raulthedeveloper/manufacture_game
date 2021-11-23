using System;
namespace Manufacture_Game
{

    public class Display
    {

        private Player PlayerData {get; set;}
        private DataStorage dataStorage { get; set; }
        private Prospects[] ProspectList { get; set; }

        public Display(Player player, DataStorage data,Prospects[] prospectList)
        {
            PlayerData = player;
            dataStorage = data;
            ProspectList = prospectList;
        }

        public void BoxContainer(object data)
        {
            Console.WriteLine("+--------------+");



            Console.WriteLine("+--------------+");

        }
        public void BoxContainer(string message)
        {
            Console.WriteLine("+--------------+");

            Console.WriteLine(message); 


        }

        public void PlayerStats()
        {
            this.BoxContainer($"Company Name: {PlayerData.CompanyName} \nMoney: {PlayerData.Money}");

            this.MainMenu();
        }

        public void Greeting(string CompanyName)
        {
            Console.WriteLine($"Welcome to Manufacture Simulation {CompanyName}");
        }

        public void MainMenu()
        {

           this.BoxContainer($"1.Buy Patents \n2.Manufacture \n3.Find Prospects\n4 View Stats [type the number]");

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
            this.BoxContainer("Welcome to buy Manufacture");
            this.MainMenu();
        }


        public void FindProspects()
        {
  
            this.BoxContainer("Its time to find some business");

            

            for (int i = 1; i < ProspectList.Length; i++)
            {
                this.BoxContainer($"{i}.Company Name: {ProspectList[i].Name}\n  Level Requirement: {ProspectList[i].LeveleRequirement}");
            }


            //DataStorage.CreateProspectList();
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
