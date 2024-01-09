using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_The_Gulag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            Console.WriteLine("Date:                    1946-04-22\nLocation:                Vorkuta Corrective Labor Camp\nSubject Name:            Yevgeniy Aleksandrov\nDate of Birth:           1921-08-16\nPlace of Origin:         Saratov, USSR\nID Number:               F319\nReason of Imprisonment:  Betrayal of The State\nSentence:                10 Years of Hard Labor\n\n\n\n");
            Console.WriteLine("*Breakfast*\n");
            Random rnd = new Random();
            int fightChance = rnd.Next(1, 6);
            if (fightChance == 1) 
            {
                Enemy enemy1 = new Enemy(10, health);
                enemy1.Fight();
            }
            Console.ReadKey();
        }
    }
}
