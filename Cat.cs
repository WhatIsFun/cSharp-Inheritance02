using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Cat : Animal
    {
        public Cat()
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Meow");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat cat food.");
        }
    }
}
