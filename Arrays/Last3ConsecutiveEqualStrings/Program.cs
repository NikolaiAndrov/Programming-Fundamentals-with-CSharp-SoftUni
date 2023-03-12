using System;
using System.Collections.Generic;
using System.Linq;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var count = 1;

            for (int i = words.Length - 1; i > 0; i--)
            {
                if (words[i] == words[i - 1])
                {
                    count++;
                    
                    if (count == 3)
                    {
                        Console.WriteLine($"{words[i]} {words[i]} {words[i]}");
                        break;
                    }
                   
                }

                else
                {
                    count = 1;
                }

            }
        }
    }
}
