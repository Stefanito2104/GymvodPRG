using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survive_The_Gulag
{
    internal class You
    {
        public int yourHealth;
        public You(int yourHealth)
        {
            this.yourHealth = yourHealth;
        }
        public void GameOver()
        {
            Console.WriteLine("You are dead!\nGame over!");
            Console.ReadKey();
            Environment.Exit(0);
        }
        public void CuttingTreesHungry()
        {
            Console.WriteLine("Because of the hunger you are working slowly and are more prone to injury.");
            Random rnd = new Random();
            int injury = rnd.Next(1, 7);
            if (injury == 1)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, a tree that you are cutting down falls on top of you.");
                GameOver();
            }
            else if (injury == 2)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, a tree that you are cutting down starts falling on you.\nYou manage to jump out of the way, but the tree falls on your leg and breaks it.");
                yourHealth = yourHealth - 15;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
            else
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, a tree that you are cutting down starts falling on you, but you manage to jump out of the way.");
            }
            int workDone = rnd.Next(1, 3);
            if (workDone == 1)
            {
                Console.ReadKey();
                Console.WriteLine("You didn't do enough work. Because of that the guards beat you up.");
                yourHealth = yourHealth - 10;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
        }
        public void CuttingTrees()
        {
            Random rnd = new Random();
            int injury = rnd.Next(1, 10);
            if (injury == 1)
            {
                Console.WriteLine("Suddenly, a tree that you are cutting down falls on top of you.");
                GameOver();
            }
            else if (injury == 2)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, a tree that you are cutting down starts falling on you.\nYou manage to jump out of the way, but the tree falls on your leg and breaks it.");
                yourHealth = yourHealth - 15;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
            else
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, a tree that you are cutting down starts falling on you, but you manage to jump out of the way.");
            }
        }
        public void BranchesHungry()
        {
            Random rnd = new Random();
            Console.ReadKey();
            Console.WriteLine("Because of the hunger you are working slowly and are more prone to injury.");
            int injury = rnd.Next(1, 4);
            if (injury == 1)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, your axe misses the log and hits your leg, but you aren't hurt much thanks to all of the cloathing you wear.");
                yourHealth = yourHealth - 5;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
            else
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, your knife slips up and cuts you, but you aren't hurt thanks to your thick gloves.");
            }
            int workDone = rnd.Next(1, 3);
            if (workDone == 1)
            {
                Console.ReadKey();
                Console.WriteLine("You didn't do enough work. Because of that the guards beat you up.");
                yourHealth = yourHealth - 10;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
        }
        public void Branches()
        {
            Random rnd = new Random();
            int injury = rnd.Next(1, 10);
            if (injury == 1)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, your axe misses the log and hits your leg, but you aren't hurt much thanks to all of the cloathing you wear.");
                yourHealth = yourHealth - 5;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
            else
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, your knife slips up and cuts you, but you aren't hurt thanks to your thick gloves.");
            }
        }
        public void Logs()
        {
            Random rnd = new Random();
            int injury = rnd.Next(1, 10);
            if (injury == 1)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, you slip and fall, and the log you are carrying falls on top of you.");
                yourHealth = yourHealth - 10;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
                Console.ReadKey();
            }
        }
        public void LogsHungry()
        {
            Random rnd = new Random();
            Console.ReadKey();
            Console.WriteLine("Because of the hunger you are working slowly and are more prone to injury.");
            int injury = rnd.Next(1, 4);
            if (injury == 1)
            {
                Console.ReadKey();
                Console.WriteLine("Suddenly, you slip and fall, and the log you are carrying falls on top of you.");
                yourHealth = yourHealth - 10;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
            int workDone = rnd.Next(1, 3);
            if (workDone == 1)
            {
                Console.ReadKey();
                Console.WriteLine("You didn't do enough work. Because of that the guards beat you up.");
                yourHealth = yourHealth - 10;
                if (yourHealth < 1)
                {
                    GameOver();
                }
                Console.WriteLine("Your remaining health: " + yourHealth);
            }
        }
        public void Finish()
        {
            Console.WriteLine("Congratulations for beating this game!");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
