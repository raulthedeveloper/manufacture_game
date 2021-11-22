using System;
namespace Manufacture_Game
{
    public class DataProcessor
    {
        private int money;

        // Used to process money, experience, level, etc
        private Player PlayerData { get; set; }

        public DataProcessor(Player Data)
        {
            PlayerData = Data;
        }

        public DataProcessor(int money)
        {
            this.money = money;
        }

        public int BuyPatent()
        {
            Console.WriteLine("Are you sure you want to buy this patent for $200,000");

            string decision = Console.ReadLine();

            if(decision == "yes")
            {
                return PlayerData.Money - 200000;
            }

            return PlayerData.Money;

            
        }

        


    }
}
