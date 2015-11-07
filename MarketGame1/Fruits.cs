using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketGame1
{
    public class Fruits
    {
        protected double weight { get; set;}
        protected string name { get; set;}
        protected int pointvalue { get; set;}

        public Fruits()
        {

        }
        public Fruits(double wt, string nme, int pv)
        {
            this.weight = wt;
            this.name = nme;
            this.pointvalue = pv;
        }
    }
}
