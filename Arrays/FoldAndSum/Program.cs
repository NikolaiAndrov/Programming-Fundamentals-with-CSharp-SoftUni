using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
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

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftNumbers[i] + middleNumbers[i];
                result[i + k] = middleNumbers[i + k] + rightNumbers[i];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
