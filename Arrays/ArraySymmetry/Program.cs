using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstText = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] secondText = new string[firstText.Length];
            bool isEquals = false;

            for (int i = 0; i < firstText.Length; i++)
            {
                secondText[i] = firstText[i];
            }

            Array.Reverse(secondText);

            for (int i = 0; i < firstText.Length; i++)
            {
                if (firstText[i] == secondText[i])
                {
                    isEquals = true;
                }
                else
                {
                    isEquals = false;
                }
            }

            if (isEquals)
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
