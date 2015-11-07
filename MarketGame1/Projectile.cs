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
        private double position;

        //Speed property
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //Position property
        public double Position
        {
            get { return position; }
            set { position = value; }
        }

        //Default constructor
        public Projectile()
        { }

        //Constructor for position value.
        public Projectile(int pos)
        {
            this.position = pos;
        }
    }
}
