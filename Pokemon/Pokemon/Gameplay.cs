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
            battleface = new BattleZone(3);
            Play();
        }

        public bool Play()
        {
            player = battleface.StayOnBattleFace(player);
            return true;
        }
      
    }
}
