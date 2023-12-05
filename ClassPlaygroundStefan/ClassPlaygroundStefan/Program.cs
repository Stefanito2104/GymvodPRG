using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlaygroundStefan
{
    internal class Program
    {
        class Human
        {
            private int age;
            public int height;
            public int weight;
            public string name;
            public string hairColor;
            public string eyeColor;
            public void PrintCharacteristics()
            {
                string printedName = name;
                if (printedName == null)
                {
                    printedName = "Bezejmenný člověk";
                }
                Console.WriteLine($"{printedName} je starý/á {age} let, měří {height} cm a váží {weight} kg");
            }
            public float BMI()
            {
                float heightForCalculation = height / 100f;
                float bmi = (float)weight / (heightForCalculation * heightForCalculation);
                return bmi;
            }
            public int GetAge()
            {
                return age;
            }
            public void SetAge(int age)
            {
                if (age < 0 || age > 130)
                {
                    Console.WriteLine("Tento věk nění možné zadat");
                }
                else
                {
                    this.age = age;
                }
            }
            public void SetAge(string age)
            {
                bool isNumber = int.TryParse(age, out int ageNumber);
                if (isNumber)
                {
                    SetAge(ageNumber);
                    Console.WriteLine($"Věk člověka {name} změněn na {this.age}");
                }
                else
                {
                    Console.WriteLine("Zadej číslo");
                }
            }
            public Human(int age, int height, int weight)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
            }
            public Human(int age, int height, int weight, string name, string hairColor, string eyeColor)
            {
                this.age = age;
                this.height = height;
                this.weight = weight;
                this.name = name;
                this.hairColor = hairColor;
                this.eyeColor = eyeColor;
            }
        }
        static void Main(string[] args)
        {
            Human human1 = new Human(32, 165, 65);
            human1.PrintCharacteristics();

            Human human2 = new Human(18, 205, 90, "Lojza", "Blonde", "Blue");
            human2.PrintCharacteristics();
            float bmi = human2.BMI();
            Console.WriteLine($"{human2.name} má BMI {bmi}");

            Human human3 = new Human(10, 130, 80);
            Console.WriteLine($"Dítě má BMI {human3.BMI()}");

            Console.WriteLine(human1.GetAge());
            human1.SetAge(50);
            Console.WriteLine(human1.GetAge());
            human1.SetAge(300);
            human1.SetAge("20");
            human1.PrintCharacteristics();
            human1.SetAge("Dvacet");
            human1.PrintCharacteristics();

            Class1 class1 = new Class1();
            Console.ReadKey();
        }
    }
}
