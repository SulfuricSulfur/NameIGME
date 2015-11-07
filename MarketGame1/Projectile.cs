using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;

namespace MarketGame1
{
    public class Projectile
    {

        //Projectile variables
        private double speed;
        private Rectangle projRect;

        //Speed property
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //Position property
        public Rectangle ProjRect
        {
            get { return projRect; }
            set { projRect = value; }
        }

        //Default constructor
        public Projectile()
        { }

        //Constructor for position value.
        public Projectile(int x, int y, int w, int h)
        {
            this.projRect = new Rectangle(x, y, w, h);
        }
    }
}
