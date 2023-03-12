using System;
using System.Collections.Generic;
using System.Linq;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var rotatedWords = new string[words.Length];

            rotatedWords[0] = words[words.Length - 1];

            for (int i = 0; i < words.Length - 1; i++)
            {
                rotatedWords[i + 1] = words[i];
            }

            Console.WriteLine(string.Join(" ",rotatedWords));
        } 
    }
}
