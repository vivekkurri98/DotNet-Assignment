using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OverloadedMethod
{
    public class Area
    {
        public double CalculateArea(double side)
        {
            return side * side;
        }

        public double CalculateArea(double length, double width) 
        { 
            return length * width;
        }

        public double CalculateArea(int radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
