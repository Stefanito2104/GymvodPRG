using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maticové_operace___Stanivuković
{
    internal class Program
    {
        static int[,] WriteMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
            return array;
        }
        static int[,] Switch(int[,] array, int element1A, int element1B, int element2A, int element2B)
        {
            int index1 = array[element1A, element1B];
            array[element1A, element1B] = array[element2A, element2B];
            array[element2A, element2B] = index1;
            return array;
        }
        static int[,] TODO2(int[,] array, int a, int b)
        {
            Console.WriteLine("Prohození prvků");
            Random rng = new Random();
            int element1A = rng.Next(0, a);
            int element1B = rng.Next(0, b);
            int element2A = rng.Next(0, a);
            int element2B = rng.Next(0, b);
            Switch(array, element1A, element1B, element2A, element2B);
            WriteMatrix(array);
            Console.Write("\n");
            Console.WriteLine("Prohození řádků");
            int elementA1 = rng.Next(0, a);
            int elementA2 = rng.Next(0, a);
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Switch(array, elementA1, i, elementA2, i);
            }
            WriteMatrix(array);
            Console.Write("\n");
            Console.WriteLine("Prohození sloupců");
            int elementB1 = rng.Next(0, b);
            int elementB2 = rng.Next(0, b);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Switch(array, i, elementB1, i, elementB2);
            }
            WriteMatrix(array);
            Console.Write("\n");
            Console.WriteLine("Prohození pořadí prvků na hlavní diagonále");
            int min = Math.Min(array.GetLength(0), array.GetLength(1));
            for (int i = 0; i < min / 2; i++)
            {
                int swap = min - 1 - i;
                Switch(array, i, i, swap, swap);
            }
            WriteMatrix(array);
            Console.Write("\n");
            Console.WriteLine("Prohození pořadí prvků na vedlejší diagonále");
            for (int i = 0; i < min / 2; i++)
            {
                int swap = min - 1 - i;
                Switch(array, i, swap, swap, i);
            }
            WriteMatrix(array);
            Console.Write("\n");
            return array;
        }
        static int[,] TODO3(int[,] array, int a, int b)
        {
            Console.WriteLine("Vynásobení matice");
            Console.Write("Kvocient: ");
            int quotient = int.Parse(Console.ReadLine());
            int[,] array2 = new int[a, b];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = array[i, j]*quotient;
                    array[i, j] = array2[i, j];
                }
            }
            WriteMatrix(array);
            Console.Write("\n");
            return array;
        }
        static int[,] TODO4(int[,] array, int a, int b)
        {
            Console.WriteLine("Sčítání a odčítání matic");
            Console.WriteLine("Nová matice");
            Random random = new Random();
            int[,] array2 = new int[a, b];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = random.Next(1, a * b + 1);
                    Console.Write(array2[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            Console.WriteLine("Sčítání");
            int[,] array3 = new int[a, b];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array3[i, j] = array[i, j] + array2[i, j];
                    array[i, j] = array3[i, j];
                }
            }
            WriteMatrix(array);
            Console.Write("\n");
            Console.WriteLine("Nová matice");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[i, j] = random.Next(1, a * b + 1);
                    Console.Write(array2[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");            
            Console.WriteLine("Odčítání");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array3[i, j] = array[i, j] - array2[i, j];
                    array[i, j] = array3[i, j];
                }
            }
            WriteMatrix(array);
            Console.Write("\n");
            return array;
        }
        static int[,] TODO5(int[,] array)
        {
            Console.WriteLine("Transpozice");
            int varmin = Math.Min(array.GetLength(0), array.GetLength(1));
            for (int i = 0; i < varmin; i++)
            {
                for (int j = 0; j < varmin; j++)
                {
                    if (i == j)
                    {
                        break;
                    }
                    else
                    {
                        Switch(array, i, j, j, i);
                    }
                }
            }
            WriteMatrix(array);
            Console.Write('\n');
            return array;
        }
        static int[,] TODO6(int[,] array, int a, int b, int c)
        {
            Console.WriteLine("Nová matice");
            Random random = new Random();
            int[,] array2 = new int[b, c];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = random.Next(1, b * c + 1);
                    Console.Write(array2[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            int[,] array3 = new int[a, c];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    int index = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        index = index + array[i, k] * array2[k, j];
                    }
                    array3[i, j] = index;
                }
            }
            Console.WriteLine("Výsledná matice");
            WriteMatrix(array3);
            return array;
        }
        static void Main(string[] args)
        {
            Console.Write("Počet řádků v první matici: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Počet sloupců v první matici: ");
            int b = int.Parse(Console.ReadLine());
            int[,] matrix = new int[a, b];
            int numbertoadd = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbertoadd;
                    numbertoadd++;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            TODO2(matrix, a, b);
            TODO3(matrix, a, b);
            TODO4(matrix, a, b);
            TODO5(matrix);
            Console.WriteLine("Násobení matic");
            Console.Write("Počet sloupců v druhé matici: ");
            int c = int.Parse(Console.ReadLine());
            TODO6(matrix, a, b, c);
            Console.ReadKey();
        }
    }        

}
