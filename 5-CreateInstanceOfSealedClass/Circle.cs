using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CreateInstanceOfSealedClass
{
    public sealed class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Calculate(Func<double, double> op)
        {
            return op(radius);
        }
    }
}
