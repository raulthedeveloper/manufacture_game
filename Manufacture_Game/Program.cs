using System;

namespace Manufacture_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Raul", 1000000, 0);

            Display display = new Display(player);

            display.Greeting(player.CompanyName);

            display.MainMenu();
        }
    }
}
