﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = {10, 20, 30, 40, 50};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Vypsání for:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("\nVypsání foreach:");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            Console.WriteLine("\nSuma:");
            int sum = 0;
            for (int i = 0;i < myArray.Length;i++) 
            {
                sum += myArray[i];
            }
            Console.WriteLine(sum);


            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            Console.WriteLine("\nPrůměr:");
            int average = sum / myArray.Length;
            Console.WriteLine(average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            Console.WriteLine("\nMaximum:");
            int max = myArray.Max();
            Console.WriteLine(max);


            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            Console.WriteLine("\nMinimum:");
            int min = myArray.Min();
            Console.WriteLine(min);


            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            Console.WriteLine("\nVyhledávání čísla:");
            int num = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < myArray.Length; i++) 
            {
                if (myArray[i] == num)
                {
                    found = true;
                    Console.WriteLine("Číslo " + num + " se nachází na indexu " + i);
                }
            }
            if (found == false) 
            {
                Console.WriteLine("Číslo " + num + " se nenachází v seznamu;");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            Console.ReadKey();
        }
    }
}
