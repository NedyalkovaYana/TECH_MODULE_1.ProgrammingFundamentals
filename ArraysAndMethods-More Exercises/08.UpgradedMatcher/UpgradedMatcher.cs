using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            //string[] productsNames = Console.ReadLine().Split().ToArray(); ;
            //long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //decimal[] priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            //while (true)
            //{
            //    string[] inputName = Console.ReadLine().Split();  //От инпута ти идва "Bread 10" няма как да го парснеш към лонг

            //    if (inputName[0] == "done") // край на цикъла
            //    {
            //        break;
            //    }

            //    //вземаш 2рия елемент от масива и го парсваш
            //    long inputQuantity = long.Parse(inputName[1]);

            //    int index = Array.IndexOf(productsNames, inputName[0]); //индекс на търсения елемент

            //    int quantityL = quantity.Length;

            //    if (index >= quantityL) // ако няма индекса на дадения елемент в quantity,го приравняваме на 0
            //    {
            //        quantity = new long[quantityL + index];

            //        for (int i = 0; i < quantityL; i++)
            //        {
            //            quantity[quantityL - 1 + i] = 0;
            //        }
            //    }

            //    // изчисляваме количеството
            //    if (quantity[index] >= inputQuantity)
            //    {
            //        decimal totalPrice = (decimal)priceOfProducts[index] * inputQuantity;
            //        quantity[index] -= inputQuantity;
            //        Console.WriteLine($"{inputQuantity} x {inputName} costs {totalPrice:F2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"We do not have enough {inputName[0]}");
            //    }
            //}
           
            var productsName = Console.ReadLine().Split(' ').ToArray();   //same length
            var inputQuantity = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();   //different length
            var productsPrice = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();  //same length

            for (long i = 0; i < long.MaxValue; i++)
            {
                var imputCommand = Console.ReadLine();
                if (imputCommand == "done")
                {
                    return;
                }
                else
                {
                    var command = imputCommand.Split(' ').ToArray();
                    long currentQuant = long.Parse(command[1]);  //value form console
                    long indexFinder = Array.IndexOf(productsName, command[0]);

                    if (indexFinder >= 0 && indexFinder <= inputQuantity.Length - 1) //-1
                    {
                        if (inputQuantity[indexFinder] >= currentQuant)
                        {

                            Console.WriteLine($"{productsName[indexFinder]} x {currentQuant} costs {(decimal)currentQuant * productsPrice[indexFinder]:f2}");
                            inputQuantity[indexFinder] = inputQuantity[indexFinder] - currentQuant;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {productsName[indexFinder]}");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {productsName[indexFinder]}");
                    }
                }
            }
            
        }
    }
}
                
    

    

