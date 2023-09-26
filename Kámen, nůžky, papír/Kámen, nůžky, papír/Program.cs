using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kámen__nůžky__papír
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kámen = 1, nůžky = 2, papír = 3");
            Random rnd = new Random();
            int pc;
            int material;
            material = Convert.ToInt32(Console.ReadLine());
            pc = rnd.Next(1, 3);
            while ((material > 1) || (material < 3))    
                if (material == pc)
                {
                    Console.WriteLine("Nikdo nevyhrává");
                }
                else if ((material == 1) && (pc == 2))
                {
                    Console.WriteLine("Vyhráváš, kámen porazí nůžky");
                }
                else if ((material == 1) && (pc == 3))
                {
                    Console.WriteLine("Prohráváš, papír porazí kámen");
                }
                else if ((material == 2) && (pc == 1))
                {
                    Console.WriteLine("Prohráváš, kámen porazí nůžky");
                }
                else if ((material == 2) && (pc == 3)) 
                {
                    Console.WriteLine("Vyhráváš, nůžky porazí papír");
                }
                else if ((material == 3) && (pc == 1))
                {
                    Console.WriteLine("Vyhráváš, papír porazí kámen");
                }
                else if ((material == 3) && (pc == 2))
                {
                    Console.WriteLine("Prohráváš, nůžky porazí papír");
                }
                pc = rnd.Next(1, 3);
                material = Convert.ToInt32(Console.ReadLine());
        }
    }
}
