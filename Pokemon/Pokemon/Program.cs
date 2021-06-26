using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOpen = true;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Game game = new Game();

            do
            {
                gameOpen = game.Game();

            } while (gameOpen);
        }
    }
}
