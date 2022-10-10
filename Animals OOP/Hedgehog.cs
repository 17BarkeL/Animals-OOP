using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP
{
    class Hedgehog : Animal
    {
        public Hedgehog(string name)
        {
            this.name = name;
        }

        public void Squeak()
        {
            Console.WriteLine($"{name} just squeaked!");
        }

        public void RollUp()
        {
            Console.WriteLine($"{name} just rolled up into a defensive ball!");
        }
    }
}
