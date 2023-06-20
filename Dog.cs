using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog Sound");
        }
    }
}
