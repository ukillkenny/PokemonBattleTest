using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;
using System.Linq;

namespace Pokemon
{
    class Game
    {
       
       public void Start()
        {

            RunMainMenu();
            WriteLine("Press any key to exit...");
            ReadKey(true);

        }

        private void RunMainMenu()
        {
            string[] options = { "New Game", "Load Game", "Exit" };
            Menu mainMenu = new Menu(options);
            int selectedIndex = mainMenu.Run();
        }

    }
}
