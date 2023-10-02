using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dostupné operace:+,-,*,/,^,odmocnina");
            Console.WriteLine("Napiš počet čísel, kterých chceš spočítat");
            int pocet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Piš svůj příklad");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double vysledek = 0;
            for (int i = 1; i < pocet; i++)
            {
                string operace = Console.ReadLine();
                if (operace == "+")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 + num;
                    num1 = vysledek;
                    continue;
                }
                else if (operace == "-")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 - num;
                    num1 = vysledek;
                    continue;
                }
                else if (operace == "*")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 * num;
                    num1 = vysledek;
                    continue;
                }
                else if (operace == "/")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 / num;
                    num1 = vysledek;
                    continue;
                }
                else if (operace == "^")
                {
                    Console.WriteLine("Na kolikátou chceš umocnit?");
                    double mocnina = Convert.ToDouble(Console.ReadLine());
                    vysledek = Math.Pow(num1, mocnina);
                    num1 = vysledek;
                    continue;
                }
                else if (operace == "odmocnina")
                {
                    Console.WriteLine("Kolikátou odmocninu chceš použít?");
                    double odmocnina = Convert.ToDouble(Console.ReadLine());
                    vysledek = Math.Pow(num1, 1/odmocnina);
                    num1 = vysledek;
                    continue;
                }
                else
                {
                    num1 = vysledek;
                    continue;
                }
            }
            Console.WriteLine(vysledek);
            Console.ReadKey();
        }
    }
}
