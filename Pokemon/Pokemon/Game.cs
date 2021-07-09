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
        public Game()
        {

        }
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


        private void NewGame()
        {
            Gameplay gameplay = new Gameplay();
            
        }

        private void LoadGame()
        {

        }
        private void ExitGame()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }


    }
}
