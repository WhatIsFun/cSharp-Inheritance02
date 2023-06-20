using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    internal class Camel : Animal
    {
        public Camel(string name, int age, string sound) : base(name, age, sound)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("Camel Sound");
        }
    }
}
