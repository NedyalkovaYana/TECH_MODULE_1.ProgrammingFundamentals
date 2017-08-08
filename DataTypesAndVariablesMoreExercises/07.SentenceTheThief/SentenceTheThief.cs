using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SentenceTheThief
{
    class SentenceTheThief
    {
        static void Main(string[] args)
        {
            string dataTypeThiefID = Console.ReadLine();
            byte countOfIDs = byte.Parse(Console.ReadLine());
            long tiefID = long.MinValue;

            while (countOfIDs > 0)
            {
                string currentID = Console.ReadLine();

                if (dataTypeThiefID == "sbyte")
                {
                    try
                    {
                        long currentIDnum = sbyte.Parse(currentID);
                        tiefID = Math.Max(currentIDnum, tiefID);
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (dataTypeThiefID == "int")
                {
                    try
                    {
                        long currentIDnum = int.Parse(currentID);
                        tiefID = Math.Max(currentIDnum, tiefID);
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (dataTypeThiefID == "long")
                {
                    try
                    {
                        long currentIDnum = long.Parse(currentID);
                        tiefID = Math.Max(currentIDnum, tiefID);
                    }
                    catch (Exception)
                    {
                    }
                }
                countOfIDs--;
            }
            if (tiefID > 0)
            {
                long sentence = (long)Math.Ceiling((decimal)tiefID / sbyte.MaxValue);
                Console.WriteLine($"Prisoner with id {tiefID} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
            else
            {
                long sentence = (long)Math.Ceiling((decimal)tiefID / sbyte.MinValue);
                Console.WriteLine($"Prisoner with id {tiefID} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
        }
    }
}
