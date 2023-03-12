using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "Odd" && input != "Even")
            {
                string[] commandArgs = input.Split(' ');

                switch (commandArgs[0] )
                {
                    case "Delete":
                        int number = int.Parse(commandArgs[1]);
                        numers.RemoveAll(x => x == number);
                        break;
                    case "Insert":
                        int index = int.Parse(commandArgs[2]);
                        int number1 = int.Parse(commandArgs[1]);
                        numers.Insert(index, number1);
                        break;
                }

                input = Console.ReadLine();
            }

            if (input == "Odd")
            {
                Console.Write(string.Join(" ", numers.Where(x => x % 2 != 0)));
            }
            if (input == "Even")
            {
                Console.Write(string.Join(" ", numers.Where(x => x % 2 == 0)));
            }
            Console.WriteLine();
        }
    }
}
