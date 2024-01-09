using System;
using System.Collections.Generic;
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
        public void Fight()
        {
            Console.WriteLine("Ayo, a fight!");
            while (enemyHealth > 0 || yourHealth > 0)
            {
                Random rnd = new Random();
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
                if (enemyHealth > 0)
                {

                }
            }
            if (yourHealth > 0)
            {
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine("Game Over!");
            }
        }
    }
}
