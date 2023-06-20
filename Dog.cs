using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Dog : Animal
    {
        public Dog()
        {
        }

        public override void makeNoise()
        {
            Console.WriteLine("Woof");
        }
        public override void Eat()
        {
            Console.WriteLine("I eat dog food.");
        }
    }
}
