using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFigur
{
    class Rectangle : Figure
    {
        private double Side1, Side2;
        public Rectangle(double s1, double s2)
        {
            Side1= s1;
            Side2= s2;
        }
        public override double Perimeter()
        {
            return 2 * (Side1 + Side2);
        }
        public override double Square()
        {
            return Side2 * Side1;
        }
    }
}
