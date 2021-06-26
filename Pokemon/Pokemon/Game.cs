using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pokemon
{
    class Game
    {
        private MainMenu mainmenu;
        private Gameplay gameplay;


        public Game()
        {
           mainmenu = new MainMenu();
           gameplay = new Gameplay();
        }

        public bool Play()
        {

        }

    }
}
