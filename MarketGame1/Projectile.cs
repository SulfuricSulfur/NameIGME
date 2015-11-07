using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketGame1
{
    public class Projectile
    {

        //Projectile variables
        private double speed;
        private int x;
        private int y;

        //Speed property
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //Position property
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        //Default constructor
        public Projectile()
        { }

        //Constructor for position value.
        public Projectile(int xPos,int yPos)
        {
            x = xPos;
            y = yPos;
        }
    }
}
