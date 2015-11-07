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
    public class Grape :Fruits
    {
        public Grape()
        {
            this.Weight = 2;
            this.Name = "Grape";
            this.Pointvalue = 12;
        }

    }
}
