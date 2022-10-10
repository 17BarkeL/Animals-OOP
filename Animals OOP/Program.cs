using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Hedgehog brian = new Hedgehog("Brian");
            brian.Eat();

            Dog john = new Dog("John", "Springer Spaniel");
            john.Fetch();
            john.Eat();
            john.RollOver();
            john.Bark();

            Console.ReadLine();
        }
    }
}
