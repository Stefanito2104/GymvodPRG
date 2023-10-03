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
            double num1 = Convert.ToDouble(Console.ReadLine());
            double vysledek = 0;
            string makej = null;
            while (makej == null)
            {
                string operace = Console.ReadLine();
                if (operace == "+")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 + num;
                    num1 = vysledek;
                    Console.WriteLine("=" + vysledek);
                    continue;
                }
                else if (operace == "-")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 - num;
                    num1 = vysledek;
                    Console.WriteLine("=" + vysledek);
                    continue;
                }
                else if (operace == "*")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 * num;
                    num1 = vysledek;
                    Console.WriteLine("=" + vysledek);
                    continue;
                }
                else if (operace == "/")
                {
                    double num = Convert.ToDouble(Console.ReadLine());
                    vysledek = num1 / num;
                    num1 = vysledek;
                    Console.WriteLine("=" + vysledek);
                    continue;
                }
                else if (operace == "^")
                {
                    double mocnina = Convert.ToDouble(Console.ReadLine());
                    vysledek = Math.Pow(num1, mocnina);
                    num1 = vysledek;
                    Console.WriteLine("=" + vysledek);
                    continue;
                }
                else if (operace == "odmocnina")
                {
                    Console.WriteLine("Kolikátou odmocninu chceš použít?");
                    double odmocnina = Convert.ToDouble(Console.ReadLine());
                    vysledek = Math.Pow(num1, 1 / odmocnina);
                    num1 = vysledek;
                    Console.WriteLine("=" + vysledek);
                    continue;
                }
                else if (operace == "=")
                {
                    vysledek = num1;
                    Console.WriteLine("=" + vysledek);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
