using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketGame1
{
    public class Fruits
    {
        private double weight;
        private string name;
        private int pointvalue;


        public int PointValue
        {
            get { return pointvalue; }
            set { pointvalue = value; }
        }
        
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Fruits()
        {

        }
    }
}
