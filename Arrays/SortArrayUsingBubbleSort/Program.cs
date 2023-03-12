using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayUsingBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isSwapped = false;

            do
            {
                isSwapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var current = numbers[i];
                    var next = numbers[i + 1];

                    if (current > next)
                    {
                        numbers[i + 1] = current;
                        numbers[i] = next;
                        isSwapped = true;
                    }
                }

            } while (isSwapped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
