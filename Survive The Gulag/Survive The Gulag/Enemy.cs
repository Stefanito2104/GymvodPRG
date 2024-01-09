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
        public Enemy(int enemyHealth, int yourHealth) 
        {
            this.enemyHealth = enemyHealth;
            this.yourHealth = yourHealth;
        }
        public void SetHealth(int yourHealth)
        {
            this.yourHealth = yourHealth;
        }
        public void Fight()
        {
            Random rnd = new Random();
            int exclamation = rnd.Next(1, 6);
            if (exclamation == 1) 
            {
                Console.WriteLine("Enemy: Now you've done it!");
            }
            else if (exclamation == 2)
            {
                Console.WriteLine("Enemy: You wanna get you ass beat?");
            }
            else if (exclamation == 3)
            {
                Console.WriteLine("Enemy: You're asking for it!");
            }
            else if (exclamation == 4)
            {
                Console.WriteLine("Enemy: I'll kill you!");
            }
            else
            {
                Console.WriteLine("Enemy: Fuck you!");
            }
            Console.WriteLine("Everyone: Ayo, a fight!");
            while (enemyHealth > 0 && yourHealth > 0)
            {
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
                        Console.WriteLine("Critical Hit!");
                        enemyHealth = enemyHealth-10;
                    }
                    else
                    {
                        Console.WriteLine("Hit!");
                        enemyHealth = enemyHealth-5;
                    }
                }
                Console.WriteLine(enemyHealth);
                Console.ReadKey();
                if (enemyHealth > 0)
                {
                    avoidChance = rnd.Next(1, 4);
                    if (avoidChance == 1)
                    {
                        Console.WriteLine("Miss!");
                    }
                    else
                    {
                        int criticalChance1 = rnd.Next(1, 6);
                        if (criticalChance1 == 1)
                        {
                            Console.WriteLine("Critical Hit!");
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
                Console.WriteLine(yourHealth);
                Console.ReadKey();
            }
            if (yourHealth > 0)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("Game Over!");
            }
            SetHealth(yourHealth);
        }
    }
}
