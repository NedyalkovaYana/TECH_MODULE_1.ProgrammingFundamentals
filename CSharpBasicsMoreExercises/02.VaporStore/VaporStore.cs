using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class VaporStore
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());           
            double gamePrice = 0.0;
            double money = balance;     
            string  gameType = Console.ReadLine();

            while (gameType != "Game Time")
            {
                if (gameType == "OutFall 4")
                {
                    gamePrice = 39.99; 
                }
                else if (gameType == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (gameType == "Zplinter Zell")
                {
                    gamePrice = 19.99; 
                }
                else if (gameType == "Honored 2")
                {
                    gamePrice = 59.99; 
                }
                else if (gameType == "RoverWatch")
                {
                    gamePrice = 29.99; 
                }
                else if (gameType == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99; 
                }
                else
                {
                    Console.WriteLine("Not Found");
                    gameType = Console.ReadLine();
                    continue;
                }
               
                if (gamePrice > money)
                {
                    Console.WriteLine("Too Expensive");
                    gameType = Console.ReadLine();
                    continue;
                }
                else
                {
                    money -= gamePrice;
                    Console.WriteLine("Bought " + gameType);
                    
                }
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                gameType = Console.ReadLine();
            }

            double remaining = balance - money;
            Console.WriteLine($"Total spent: ${remaining:f2}. Remaining: ${money:f2}");
        }
       
        }
    }

