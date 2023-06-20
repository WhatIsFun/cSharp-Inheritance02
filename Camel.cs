using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Camel : Animal
    {
        public Camel()
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Camel Sound");
        }
    }
}
