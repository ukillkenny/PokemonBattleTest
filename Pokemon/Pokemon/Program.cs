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
            Console.ForegroundColor = ConsoleColor.Red;
            

            Game mygame = new Game();
            mygame.Start();

          
        }
    }
}
