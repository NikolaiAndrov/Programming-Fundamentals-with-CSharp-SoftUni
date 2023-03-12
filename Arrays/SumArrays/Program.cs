using System;
using System.Collections.Generic;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var num2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var len = Math.Max(num1.Length, num2.Length);
            var result = new int[len];

            for (int i = 0; i < len; i++)
            {
                result[i] =
                    num1[i % num1.Length] +
                    num2[i % num2.Length];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
