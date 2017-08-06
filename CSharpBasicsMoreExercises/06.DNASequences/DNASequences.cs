using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            int dnaSum = int.Parse(Console.ReadLine());
            char[] dna = new char[] { 'O', 'A', 'C', 'G', 'T', 'X' };
            int counter = 0;

            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        counter++;
                        if (i + k + j >= dnaSum)
                        {
                            Console.Write($"{dna[0]}{dna[i]}{dna[k]}{dna[j]}{dna[0]} ");
                        }
                        else
                        {
                            Console.Write($"{dna[5]}{dna[i]}{dna[k]}{dna[j]}{dna[5]} ");
                        }
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
