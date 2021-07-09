using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Pokemon
{
    class BattleZone
    {
        enum Options { Fight, Save, Leave, Error }
        enum OnFinishFightOption { Next, Save, Leave, Error}

        private List<Enemy> enemies;
        private int LastEnemySeen;

        public BattleZone(int enemyAmount)
        {
            enemies = new List<Enemy>();
            for (int i = 0; i < enemyAmount; i++)
            {
                enemies.Add(new Enemy("Misty"));
                enemies.Add(new Enemy("Ritchie"));
                enemies.Add(new Enemy("Tyson"));
            }
        }

        public Player StayOnBattleFace (Player player)
        {
            WriteLine("Hi Ash! Welcome to the pokemon battlefield, select your opponent.\n");

        
        }

    }
}
