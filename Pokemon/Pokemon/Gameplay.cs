using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Console;

namespace Pokemon
{
    public class Gameplay
    {
        private Player player;
        private BattleZone battleface;
       
        public Gameplay()
        {
            Clear();
            player = new Player("Ash");
            battleface = new BattleZone();
           
        }

        public bool Play()
        {

            return true;
        }
      
    }
}
