using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_OOP
{
    class Dog : Animal
    {
        string breed;

        List<string> fetchObjects = new List<string> {"ball", "stick", "bird"};
        Random random = new Random();

        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }

        public void Fetch()
        {
            string fetchObject = fetchObjects[random.Next(fetchObjects.Count)];
            Console.WriteLine($"{name} just fetched a {fetchObject}!");
        }

        public void Bark()
        {
            Console.WriteLine($"{name} just barked!");
        }

        public void RollOver()
        {
            Console.WriteLine($"{name} just rolled over!");
        }
    }
}
