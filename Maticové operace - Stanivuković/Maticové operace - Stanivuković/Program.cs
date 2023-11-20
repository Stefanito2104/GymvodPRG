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
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
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
            int element1a = Convert.ToInt32(Console.ReadLine());
            int element1b = Convert.ToInt32(Console.ReadLine());
            int element2a = Convert.ToInt32(Console.ReadLine());
            int element2b = Convert.ToInt32(Console.ReadLine());
            int index1 = matrix[element1a, element1b];
            matrix[element1a, element1b] = matrix[element2a, element2b];
            matrix[element2a, element2b] = index1;
            Console.ReadKey();
        }
    }
}
