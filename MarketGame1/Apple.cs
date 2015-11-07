using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketGame1
{
    public class Apple :Fruits
    {
        public Apple(double wt, string nme, int pv)
        {
            this.weight = wt;
            this.name = nme;
            this.pointvalue = pv;
        }

    }
}
