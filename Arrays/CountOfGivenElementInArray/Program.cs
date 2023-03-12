using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var n = int.Parse(Console.ReadLine());

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
