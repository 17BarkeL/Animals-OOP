using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP
{
    class Animal
    {
        public string name;
        public int hunger;

        public void Eat()
        {
            Console.WriteLine($"{name} just ate!");
        }
    }
}
