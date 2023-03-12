using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            var result = int.MinValue;


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

               if (numbers[i] > result)
               {
                    result = numbers[i];
               }
            }

            Console.WriteLine(result);
        }
    }
}
