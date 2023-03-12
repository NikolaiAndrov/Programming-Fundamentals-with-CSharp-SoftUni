using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry2
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            bool isSymetryc = true;

            for (int i = 0; i < words.Length / 2; i++)
            {
                string firstWord = words[i];
                string secondWord = words[words.Length - 1 - i];

                if (firstWord != secondWord)
                {
                    isSymetryc = false;
                    break;
                }
            }

            if (isSymetryc)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
