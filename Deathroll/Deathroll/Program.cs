using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int gold = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int deathroll = rnd.Next(1, gold + 1);
            while (gold > 1)
            { 
                Console.WriteLine("User rolls " + deathroll + " (1-" + gold + ")");
                if (deathroll == 1)
                {
                    Console.WriteLine("You Lose!");
                    break;
                }
                gold = deathroll;
                deathroll = rnd.Next(1, gold + 1);
                Console.ReadKey();
                Console.WriteLine("Computer rolls " + deathroll + " (1-" + gold + ")");
                if (deathroll == 1)
                {
                    Console.WriteLine("You Win!");
                    break;
                }
                gold = deathroll;
                deathroll = rnd.Next(1, gold + 1);
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
