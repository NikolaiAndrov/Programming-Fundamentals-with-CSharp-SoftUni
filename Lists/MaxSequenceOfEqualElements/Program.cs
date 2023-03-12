using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int count = 1;
            int maxCount = 0;
            int currentNumber = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        currentNumber = numbers[i];
                    }
                }

                else
                {
                    count = 1;
                }

            }

            if (count == 1)
            {
                Console.WriteLine(count);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}
