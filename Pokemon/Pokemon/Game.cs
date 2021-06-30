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
        }

        private void RunMainMenu()
        {
            string[] options = { "New Game", "Load Game", "Exit" };
            Menu mainMenu = new Menu(options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    NewGame();
                    break;
                case 2:
                    LoadGame();
                    break;
                case 3:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void NewGame()
        {

        }

        private void LoadGame ()
        {

        }

    }
}
