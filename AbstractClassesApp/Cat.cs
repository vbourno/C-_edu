using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesApp
{
    internal class Cat : AbstractAnimal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} is saying hello.");
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Age}";
        }
    }
}
