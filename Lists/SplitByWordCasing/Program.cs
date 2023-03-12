using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var separators = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            var words = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseWords = new List<string>();
            var upperCaeWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                var isLowerLetters = true;
                var isUpperLetters = true;

                for (int i = 0; i < word.Length; i++)
                {

                    if (char.IsLower(word[i]))
                    {
                        isUpperLetters = false;
                    }

                    else if (char.IsUpper(word[i]))
                    {
                        isLowerLetters = false;
                    }
                    else
                    {
                        isLowerLetters = false;
                        isUpperLetters = false;
                    }
                }

                if (isLowerLetters)
                {
                    lowerCaseWords.Add(word);
                }
                else if (isUpperLetters)
                {
                    upperCaeWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ",mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaeWords));
        }
    }
}
