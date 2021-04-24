using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_LadderGame
{
    class Method
    {
        public static int PositionCheck(int dice, int player, int snake)
        {

            switch (dice)
            {
                case 1:
                    player = player + 1;
                    break;
                case 2:
                    player = player + 2;
                    break;
                case 3:
                    player = player + 3;
                    break;
                case 4:
                    player = player + 4;
                    break;
                case 5:
                    player = player + 5;
                    break;
                case 6:
                    player = player + 6;
                    break;

            }
            if (dice == snake)
                player = player - snake;
            return player;
        }
        
    }
}
