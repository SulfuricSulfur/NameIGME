using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketGame1
{
    /// <summary>
    /// This class contains platforms, platforms can be stood upon and have a position. Set their rect to their width and height at the position given.
    /// </summary>
    class Platform
    {
        int x;
        int y;
        int width;
        int height;

        public Platform(int xPos,int yPos, int widthSet, int heightSet)
        {
            x = xPos;
            y = yPos;
            width = widthSet;
            height = heightSet;
        }





    }
}
