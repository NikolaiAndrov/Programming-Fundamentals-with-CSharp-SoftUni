using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                char character = currentWord[0];

                if (currentWord.Length == 1)
                {
                    if (character >= 'A' && character <= 'Z')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
