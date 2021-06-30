using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using System.Linq;

namespace Pokemon
{
    class Menu
    {
        private int SelectIndex;
        private string[] Options;
        public Menu(string[] options)
        {
            Options = options;
            SelectIndex = 0;
            
        }

       private void DisplayOptions()
        {

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectIndex)
                {
                    prefix = "                           ->";
                    ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "                           ";
                    ForegroundColor = ConsoleColor.Red;
                }

                WriteLine($"{prefix} {currentOption} ");
            }
         }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                string filePath = @"C:\Users\Tulio\Desktop\PokemonBattleTest\Pokemon\Pokemon\Text\Intro.txt";

                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                foreach (String line in lines)
                {
                    WriteLine(line);
                }

                WriteLine("\n");
                WriteLine("\n");
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // Movimiento de flechas

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectIndex--;
                    if (SelectIndex == -1)
                    {
                        SelectIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectIndex++;
                    if (SelectIndex == Options.Length)
                    {
                        SelectIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectIndex;
        }
    }
}
