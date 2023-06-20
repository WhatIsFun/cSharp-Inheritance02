using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea() //Override the GetArea() method
        {
            return length * width;
        }
        public override double GetPerimeser() // Override the GetPerimeter() method
        {
            return 2 * (length + width);
        }
    }
}
