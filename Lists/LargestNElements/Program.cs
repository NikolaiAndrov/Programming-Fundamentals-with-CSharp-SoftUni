using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numbersToTake = int.Parse(Console.ReadLine());
            var result = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbersToTake; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
