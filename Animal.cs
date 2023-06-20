using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Override
{
    abstract class Animal
    {
        
        public Animal ()
        {

        }
        public virtual void makeNoise()
        {
            Console.WriteLine("I make some noise.");
        }

        public virtual void Eat()
        {
            Console.WriteLine("I eat some food.");
        }


        }
}
