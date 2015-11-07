using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketGame1
{
    public class Fruits
    {
        private double weight { get; set }
        private string name { get; set };   
        private int pointvalue { get; set };

       
        public Fruits(double wt, string nme, int pv)
        {
            this.weight = wt;
            this.name = nme;
            this.pointvalue = pv;
        }
    }
}
