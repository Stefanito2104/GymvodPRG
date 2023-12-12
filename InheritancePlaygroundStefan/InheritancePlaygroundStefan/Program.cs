using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePlaygroundStefan
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;
            public int endangerment;
            public virtual void AnimalNoise()
            {
                Console.WriteLine("*happy animal noises*");
            }
        }
        class Dog : Animal
        {
            public int numberOfPuppies;
            public string race;
            public override void AnimalNoise()
            {
                Console.WriteLine("Woof woof!");
            }
        }
        static void Main(string[] args)
        {
            Dog newDog = new Dog();
            newDog.name = "Fido";
            newDog.race = "Labrador";
            newDog.AnimalNoise();
            Console.ReadKey();
        }
    }
}
