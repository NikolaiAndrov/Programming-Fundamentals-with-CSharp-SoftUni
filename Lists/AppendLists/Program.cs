using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {'|'},
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            numbers.Reverse();

            var result = new List<string>();

            foreach (var number in numbers)
            {
                var nums = number.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                result.AddRange(nums);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
