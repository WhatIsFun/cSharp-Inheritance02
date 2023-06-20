using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Circle : Shape
    {
        private double radius;
        private double PI = 3.14;

        public Circle (double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return PI*radius*radius;
        }
        public override double GetPerimeser()
        {
            return 2 * PI * radius;
        }
    }
}

