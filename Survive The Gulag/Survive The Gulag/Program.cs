using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Survive_The_Gulag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            You you = new You(100);
            Random rnd = new Random();
            Console.WriteLine("Date:                    1946-04-22\nLocation:                Vorkuta Corrective Labor Camp\nSubject Name:            Yevgeniy Aleksandrov\nDate of Birth:           1921-08-16\nPlace of Origin:         Saratov, USSR\nID Number:               F319\nReason of Imprisonment:  Betrayal of The State\nSentence:                20 Years of Hard Labor\n\n\n\n");
            Console.ReadKey();
            Console.WriteLine("You were arrested and sent to a labor camp for leading an anti-communist political party.");
            Console.ReadKey();
            Console.WriteLine("The doctor is currently not present. He will be back in 3 days.");
            Console.ReadKey();
            Console.WriteLine("Your health: " + you.yourHealth + "\n");
            Console.ReadKey();
            Console.WriteLine("You wake up and go to eat breakfast. there are 3 people with empty seats next to them.\nWho do you sit next to?");
            Console.WriteLine("1. T897\n2. P523\n3. R411");
            string sit = Console.ReadLine();
            switch(sit)
            {
                case "1":
                    {
                        Console.WriteLine("You sit next to him and he introduces himself as Boris. He tells you that he wants to escape.");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You try to sit next to him, but he just lunges at you. He wants to fight you.");                
                        Enemy enemy1 = new Enemy(10, you.yourHealth, "P523");
                        enemy1.Fight();
                        you.yourHealth = enemy1.yourHealth;
                        if (you.yourHealth < 1)
                        {
                            you.GameOver();
                        }
                        Console.WriteLine("He's taken to the infirmary. You sit in his seat.\nBecause of the fight you didn't have enough time to eat properly, and you will be hungry."); 
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You try to sit next to him, but he just tells you to go away. You go sit next to someone else.\nWho do you sit next to?");
                        Console.WriteLine("1. T897\n2. P523");
                        sit = Console.ReadLine();
                        switch (sit)
                        {
                            case "1":
                                {
                                    Console.WriteLine("You sit next to him and he introduces himself as Boris. He tells you that he wants to escape.");
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("You try to sit next to him, but he just lunges at you. He wants to fight you.");
                                    Enemy enemy1 = new Enemy(10, you.yourHealth, "P523");
                                    enemy1.Fight();
                                    you.yourHealth = enemy1.yourHealth;
                                    if (you.yourHealth < 1)
                                    {
                                        you.GameOver();
                                    }
                                    Console.WriteLine("He's taken to the infirmary. You sit in his seat.\nBecause of the fight you didn't have enough time to eat properly, and you will be hungry.");
                                    break;
                                }
                        }
                        break;
                    }
            }
            Console.ReadKey();
            Console.WriteLine("\nAfter breakfast you have to work. You will be doing forestry.\nThere are multiple positions you can take. What position do you choose?");
            Console.WriteLine("1. Cutting down trees\n2. Cutting off the branches and cutting logs into smaller pieces\n3. Carrying logs to the drop-off point");
            string escape = null;
            string work = Console.ReadLine();
            switch (work)
            {
                case "1":
                    {
                        Console.WriteLine("You are working on your own.");
                        Console.ReadKey();
                        if (sit == "2")
                        {
                            you.CuttingTreesHungry();
                        }
                        else
                        {
                            you.CuttingTrees();
                        }
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You are working on your own.");
                        Console.ReadKey();
                        if (sit == "2")
                        {
                            you.BranchesHungry();
                        }
                        else
                        {
                            you.Branches();
                        }
                        break;
                    }
                case "3":
                    {
                        if (sit == "1")
                        {
                            Console.WriteLine("You are working together with Boris.");
                            you.Logs();
                            Console.WriteLine("Boris tells you that he will try to escape tommorow and wants you to go with him.\nDo you accept his offer? (y or n)");
                            escape = Console.ReadLine().ToLower();
                            switch (escape)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("He understands your concern, but tells you to think about it until then.");
                                        break;
                                    }
                            }
                        }
                        if (sit == "2")
                        {
                            Console.WriteLine("You are working together with T897. He introduces himself as Boris and tells you that he wants to escape.");
                            you.LogsHungry();
                        }
                        break;
                    }
            }
            Console.ReadKey();
            string escape2 = null;
            string snitch = null;
            Console.WriteLine("\nAfter work you have dinner. There are 2 people with empty seats next to them.\nWho do you sit next to?");            
            if (sit == "1" || work == "3")
            {
                Console.WriteLine("1. Boris\n2. B162");
            }
            else
            {
                Console.WriteLine("1. T897\n2. B162");
            }
            string sit2 = Console.ReadLine();
            switch (sit2)
            {
                case "1":
                    {
                        if (sit == "1" && escape == "y")
                        {
                            Console.WriteLine("He asks you if you are sure you want to escape. (y or n)");
                            escape2 = Console.ReadLine();
                            switch (escape2)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He praises you for your bravery.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("He tells you to think about it until then.");
                                        break;
                                    }
                            }
                            
                        }
                        else if (sit == "1" && escape == "n")
                        {
                            Console.WriteLine("He asks you again if you want to escape. (y or n)");
                            escape2 = Console.ReadLine();
                            switch (escape2)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("He tells you to think about it until then.");
                                        break;
                                    }
                            }
                        }
                        else if (sit == "1" || work == "3")
                        {
                            Console.WriteLine("He tells you that he will try to escape tommorow and wants you to go with him.\nDo you accept his offer (y or n)?");
                            escape2 = Console.ReadLine();
                            switch (escape2)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("He understands your concern, but tells you to think about it until then.");
                                        break;
                                    }
                            }
                        }
                        else
                        {
                            Console.WriteLine("He introduces himself as Boris and tells you that he wants to escape.");
                        }
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("He introduces himself as Anton.\nHe tells you that he is on good terms with the guards and that he can get you bigger food rations for snitching on others.");
                        if (sit == "1" || work == "3")
                        {
                            Console.WriteLine("Do you snitch on Boris? (y or n)");
                            snitch = Console.ReadLine();
                            switch (snitch)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He thanks you and promises you double the food rations you're getting now.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("he tells you that if you know something about anyone to tell him.");
                                        break;
                                    }
                            }
                        }
                        break;
                    }
            }
            Console.ReadKey();
            Console.WriteLine("After dinner you go to sleep.");
            Console.ReadKey();
            string escape3 = null;
            string sit3 = null;
            Console.WriteLine("\nYou wake up and go to eat breakfast.");
            if ((sit == "1" && escape == "y") || (sit == "1" && escape2 == "y") || (work == "3" && escape2 == "y") || (sit == "1" && escape == "y" && escape2 == "y") || (sit == "1" && escape == "n" && escape2 == "y"))
            {
                Console.WriteLine("Boris calls you over to his table. There are multiple people there.\nHe introduces you to everyone. Everyone here wants to escape.");
                escape3 = "y";
            }
            else if ((sit == "1" && escape == "n") || (sit == "1" && escape2 == "n") || (work == "3" && escape2 == "n") || (sit == "1" && escape == "n" && escape2 == "n") || (sit == "1" && escape == "y" && escape2 == "n"))
            {
                Console.WriteLine("Boris calls you over to his table. There are multiple people there.\nHe asks you again if you want to escape with him. (y or n)");
                escape3 = Console.ReadLine();
                switch(escape3)
                {
                    case "y":
                        {
                            Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("He understands your concern, but tells you to think about it until tommorow.");
                            break;
                        }
                }
            }
            else if (sit == "1" || work == "3" || sit2 == "1")
            {
                Console.WriteLine("Boris calls you over to his table. There are multiple people there.\nHe tells you that he will try to escape tommorow and wants you to escape with him.\nDo you accept his offer? (y or n)");
                escape3 = Console.ReadLine();
                switch (escape3)
                { 
                    case "y":
                        {
                            Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("He understands your concern, but tells you to think about it until tommorow.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("1. T897\n2. Anton\n3. M284");
                sit3 = Console.ReadLine();
                switch (sit3)
                {
                    case "1":
                        {
                            Console.WriteLine("You sit next to him and he introduces himself as Boris. There are multiple people there.\nHe tells you that he will try to escape tommorow and asks you if you want to escape with him.\nDo you accept his offer? (y or n)");
                            escape3 = Console.ReadLine();
                            switch (escape3)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("He understands your concern, but tells you to think about it until tommorow.");
                                        break;
                                    }
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("He asks you again if you know something suspicious about anyone.");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("You try to sit next to him, but he just lunges at you. He wants to fight you.");
                            Enemy enemy1 = new Enemy(10, you.yourHealth, "M284");
                            enemy1.Fight();
                            you.yourHealth = enemy1.yourHealth;
                            if (you.yourHealth < 1)
                            {
                                you.GameOver();
                            }
                            Console.WriteLine("He's taken to the infirmary. You sit in his seat.\nBecause of the fight you didn't have enough time to eat properly, and you will be hungry.");
                            break;
                        }
                }
            }
            Console.ReadKey();
            Console.WriteLine("\nAfter breakfast you have to work. You will be doing forestry again.\nThere are multiple positions you can take. What position do you choose?");
            Console.WriteLine("1. Cutting down trees\n2. Cutting off the branches and cutting logs into smaller pieces\n3. Carrying logs to the drop-off point");
            string escape4 = null;
            string work2 = Console.ReadLine();
            switch (work2)
            {
                case "1":
                    {
                        Console.WriteLine("You are working on your own.");
                        Console.ReadKey();
                        if (sit == "2")
                        {
                            you.CuttingTreesHungry();
                        }
                        else
                        {
                            you.CuttingTrees();
                        }
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You are working on your own.");
                        Console.ReadKey();
                        if (sit == "2")
                        {
                            you.BranchesHungry();
                        }
                        else
                        {
                            you.Branches();
                        }
                        break;
                    }
                case "3":
                    {
                        if ((sit2 == "1" && escape3 == "y") || (sit == "1" && escape == "y") || (sit == "1" && escape2 == "y") || (sit == "1" && escape3 == "y")) 
                        {
                            Console.WriteLine("You are working together with Boris.");
                            you.Logs();
                            Console.WriteLine("He tells you that the escape will happen here at this time tommorow.");
                            escape4 = "y";
                        }
                        else if ((sit2 == "1" && escape3 == "n") || (sit == "1" && escape == "n") || (sit == "1" && escape2 == "n") || (sit == "1" && escape3 == "n"))
                        {
                            Console.WriteLine("You are working together with Boris.");
                            you.Logs();
                            Console.WriteLine("He asks you again if you want to escape with him. (y or n)");
                            escape4 = Console.ReadLine();
                            switch (escape4)
                            {
                                case "y":
                                    {
                                        Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                                        break;
                                    }
                                case "n":
                                    {
                                        Console.WriteLine("He understands your concern, but tells you to think about it until tommorow.");
                                        break;
                                    }
                            }
                        }
                        else if (sit == "2" && (work == "1" || work == "2") && sit2 == "2" && sit3 == "3")
                        {
                            Console.WriteLine("You are working together with T897. He introduces himself as Boris and tells you that he wants to escape.");
                            you.LogsHungry();
                        }
                        else
                        {
                            Console.WriteLine("You are working together with T897. He introduces himself as Boris and tells you that he wants to escape.");
                            you.Logs();
                        }
                    }
                    break;
            }
            Console.ReadKey();
            if (sit2 == "2" || sit3 == "2")
            {
                Console.WriteLine("\nAfter work you have dinner. There is only one seat available, next to Anton.\nHe asks you again if you know something suspicious about anyone.");
                if (sit == "1" || work == "3" || sit2 == "1" || sit3 == "1" || work2 == "3")
                {
                    Console.WriteLine("Do you snitch on Boris? (y or n)");
                    snitch = Console.ReadLine();
                    switch (snitch)
                    {
                        case "y":
                            {
                                Console.WriteLine("He thanks you and promises you double the food rations you're getting now.");
                                break;
                            }
                        case "n":
                            {
                                Console.WriteLine("He tells you that if you know something about anyone to tell him.");
                                break;
                            }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nAfter work you have dinner. There is only one seat available, next to B162.\nHe introduces himself as Anton.\nHe tells you that he is on good terms with the guards and that he can get you bigger food rations for snitching on others.");
                Console.WriteLine("Do you snitch on Boris? (y or n)");
                snitch = Console.ReadLine();
                switch (snitch)
                {
                    case "y":
                        {
                            Console.WriteLine("He thanks you and promises you double the food rations you're getting now.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("He tells you that if you know something about anyone to tell him.");
                            break;
                        }
                }
            }
            Console.WriteLine("After dinner you go to sleep.");
            Console.ReadKey();
            string escape5 = null;
            Console.WriteLine("\nYou wake up and go to eat breakfast.");
            if (escape4 == "y" || escape3 == "y" || escape2 == "y" || escape == "y")
            {
                Console.WriteLine("There is only one seat available, next to Boris.\nHe tells you to be ready for his signal");
                escape5 = "y";
            }      
            else if (escape4 == "n")
            {
                Console.WriteLine("There is only one seat available, next to Boris.\nHe asks you one last time if you want to escape with him. (y or n)");
                escape5 = Console.ReadLine();
                switch (escape5)
                {
                    case "y":
                        {
                            Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("He understands and tells you to take care.");
                            break;
                        }
                }
            }
            else if (sit == "1" || work == "3" || sit2 == "1" || work2 == "3")
            {
                Console.WriteLine("There is only one seat available, next to Boris.\nHe tells you that he will try to escape today and asks you if you want to escape with him.\nDo you accept his offer? (y or n)");
                escape5 = Console.ReadLine();
                switch (escape5)
                {
                    case "y":
                        {
                            Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("He understands and tells you to take care.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("You sit next to him and he introduces himself as Boris.\nHe tells you that he will try to escape tommorow and asks you if you want to escape with him.\nDo you accept his offer? (y or n)");
                escape5 = Console.ReadLine();
                switch (escape5)
                {
                    case "y":
                        {
                            Console.WriteLine("He tells you his plan. He plans to escape during work in the forest. The trees can protect you from bullets.");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("He understands and tells you to take care.");
                            break;
                        }
                }
            }
            Console.ReadKey();
            Console.WriteLine("\nAfter breakfast you have to work, but there's been a change today. You will be working in a coal mine together with Boris and Anton.");
            if (snitch == "y")
            {
                Console.WriteLine("You see Guards come up to Boris and everyone who was at that table yesterday and start beating them up and then shooting them.\nThe gurads come to you and tell you that you don't have to work today anymore and your sentence has been halved.");
                you.Finish();
            }
            Console.WriteLine("Do you snitch on Boris? (y or n)");
            snitch = Console.ReadLine();
            switch (snitch)
            {
                case "y":
                    {
                        Console.WriteLine("Anton thanks you and promises you double the food rations you're getting now.\nYou see Guards come up to Boris and everyone who was at that table yesterday and start beating them up and then shooting them.\nThe gurads come to you and tell you that you don't have to work today anymore and your sentence has been halved.");
                        you.Finish();
                        break;
                    }
                case "n":
                    {
                        if (escape5 == "y")
                        {
                            Console.WriteLine("You hear Boris yell 'Run my brothers!' and you and everyone start screaming and running away.\nThe guards start shooting at you.");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.ReadKey();
                                int shoot = rnd.Next(1, 3);
                                if (shoot == 1)
                                {
                                    Console.WriteLine("You have been shot!");
                                    you.yourHealth = you.yourHealth - 10;
                                    if (you.yourHealth < 1)
                                    {
                                        you.GameOver();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Miss!");
                                }
                            }
                            Console.WriteLine("Your remaining health: " + you.yourHealth);
                            Console.ReadKey();
                            Console.WriteLine("There is just one guard blocking your way to freedom right in front of you.\nHe can't shoot you, but you have to fight him.");
                            Enemy guard = new Enemy(20, you.yourHealth, "Guard");
                            guard.Fight();
                            if (you.yourHealth < 1)
                            {
                                you.GameOver();
                            }
                            Console.WriteLine("You managed to escape the Vorkuta gulag.");
                            you.Finish();
                        }
                        else
                        {
                            Console.WriteLine("You hear Boris yell 'Run my brothers!' and everyone starts screaming and running away.\nYou see that a lot of them managed to escape, but some didn't make it");
                            Console.WriteLine("You and Anton are the only prisoners left in the mine. He and the guards congratulate you for not running away.\nYou are told you can take the rest of the day off.");
                            you.Finish();
                        }
                        break;
                    }
            }    
        }
    }
}