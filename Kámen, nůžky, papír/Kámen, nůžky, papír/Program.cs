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
            int material = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
<<<<<<< HEAD
            int kompl = rnd.Next(1, 4);
            while ((material >= 1) || (material <= 3))
            {
                if (material == kompl)
                {
                    Console.WriteLine("Nikdo nevyhrává");
                }
                else if ((material == 1) && (kompl == 2))
=======
            int pc;
            int material;
            material = Convert.ToInt32(Console.ReadLine());
            pc = rnd.Next(1, 3);
            while (material > 1 || material < 3)    
                if (material == pc)
                {
                    Console.WriteLine("Nikdo nevyhrává");
                }
                else if (material == 1 && pc == 2)
>>>>>>> 60b1f9b49cd20a4e9f492fe4d3f46d0e29c76b75
                {
                    Console.WriteLine("Vyhráváš, kámen porazí nůžky");
                }
                else if ((material == 1) && (kompl == 3))
                {
                    Console.WriteLine("Prohráváš, papír porazí kámen");
                }
                else if ((material == 2) && (kompl == 1))
                {
                    Console.WriteLine("Prohráváš, kámen porazí nůžky");
                }
                else if ((material == 2) && (kompl == 3))
                {
                    Console.WriteLine("Vyhráváš, nůžky porazí papír");
                }
                else if ((material == 3) && (kompl == 1))
                {
                    Console.WriteLine("Vyhráváš, papír porazí kámen");
                }
                else if ((material == 3) && (kompl == 2))
                {
                    Console.WriteLine("Prohráváš, nůžky porazí papír");
                }
                else
                {
                    Console.WriteLine("Zadej správnou hodnotu");
                }
                material = Convert.ToInt32(Console.ReadLine());
                kompl = rnd.Next(1, 4);
            }
        }
    }
}
