using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            int[] leftNumbers = numbers.Take(k).ToArray();
            int[] middleNumbers = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightNumbers = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftNumbers);
            Array.Reverse(rightNumbers);
            int[] concatArrays = leftNumbers.Concat(rightNumbers).ToArray();

            int[] result = new int[middleNumbers.Length];

            for (int i = 0; i < middleNumbers.Length; i++)
            {
                result[i] = middleNumbers[i] + concatArrays[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }    
    }
}
