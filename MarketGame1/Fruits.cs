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
    public class Fruits
    {
        //Fruit attributes
        private double weight;
        private string name;
        private int pointvalue;
        private Rectangle rect;

        //Properties for each attribute
        public double Weight
        {
            get { return weight; }
            set { weight= value; }
        }
        public int Pointvalue
        {
            get { return pointvalue; }
            set { pointvalue = value; }
        }

        public string Name
        {
            get { return Name; }
            set { Name= value; }
        }

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }
        public Fruits()
        {

        }
        public Fruits(int x, int y, int w, int h)
        {
            this.rect = new Rectangle(x, y, w, h);
        }
    }
}
