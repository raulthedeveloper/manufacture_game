using System;
using System.IO;
using System.Text.Json;

namespace Manufacture_Game
{

    //public class WeatherForecast
    //{
    //    public DateTimeOffset Date { get; set; }
    //    public int TemperatureCelsius { get; set; }
    //    public string Summary { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {

            string fileName = "Data/GameData.json";
            string jsonString = File.ReadAllText(fileName);
           Program GameData = JsonSerializer.Deserialize<Program>(jsonString);

            Console.WriteLine(GameData);



            Player player = new Player("Raul", 1000000, 0);
            DataStorage dataStorage = new DataStorage();

            

            Prospects[] prospectList = dataStorage.CreateProspectList();

                  

            Display display = new Display(player, dataStorage,prospectList);


            display.Greeting(player.CompanyName);

            display.MainMenu();
        }

        
        }
}
