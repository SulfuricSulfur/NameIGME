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
    public class Watermelon : Fruits
    {
        public Watermelon()
        {
            this.Weight = 5;
            this.Name = "Watermelon";
            this.Pointvalue = 30;
        }

    }
}
