using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_The_Gulag
{
    internal class Enemy
    {
        public int enemyHealth, yourHealth;
        public string id;
        public Enemy(int enemyHealth, int yourHealth, string id) 
        {
            this.enemyHealth = enemyHealth;
            this.yourHealth = yourHealth;
            this.id = id;
        }
        public void Fight()
        {
            Random rnd = new Random();
            while (yourHealth > 0 && enemyHealth > 0)
            {
                if (enemyHealth > 0)
                {
                    Console.ReadKey();
                    Console.WriteLine(id + " throws a punch!");
                    Console.ReadKey();
                    int avoidChance = rnd.Next(1, 4);
                    if (avoidChance == 1)
                    {
                        Console.WriteLine("Miss!");
                    }
                    else
                    {
                        int criticalChance = rnd.Next(1, 6);
                        if (criticalChance == 1)
                        {
                            Console.WriteLine("Critical hit!");
                            yourHealth = yourHealth - 10;
                        }
                        else
                        {
                            Console.WriteLine("Hit!");
                            yourHealth = yourHealth - 5;
                        }
                    }
                }
                else
                {
                    continue;
                }
                Console.ReadKey();
                if (yourHealth > 0)
                {
                    Console.WriteLine("You throw a punch!");
                    Console.ReadKey();
                    int avoidChance = rnd.Next(1, 4);
                    if (avoidChance == 1)
                    {
                        Console.WriteLine("Miss!");
                    }
                    else
                    {
                        int criticalChance1 = rnd.Next(1, 6);
                        if (criticalChance1 == 1)
                        {
                            Console.WriteLine("Critical hit!");
                            enemyHealth = enemyHealth - 10;
                        }
                        else
                        {
                            Console.WriteLine("Hit!");
                            enemyHealth = enemyHealth - 5;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
            if (yourHealth > 0)
            {
                Console.WriteLine("You win! Your remaining health: " + yourHealth + "\n");
                Console.ReadKey();
            }
        }
    }
}
