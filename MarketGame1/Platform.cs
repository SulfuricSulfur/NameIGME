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
    class Platform
    {
        private Rectangle platRect;

        public Platform(int x, int y, int w, int h)
        {
            platRect = new Rectangle(x, y, w, h);
        }
    }
}
