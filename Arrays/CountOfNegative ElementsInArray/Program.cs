using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfNegative_ElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
