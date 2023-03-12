using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var coffees = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];

            if (command == "Include")
            {
                var coffee = args[1];
                coffees.Add(coffee);
            }
            else if (command == "Remove")
            {
                var direction = args[1];
                var count = int.Parse(args[2]);

                if (count > coffees.Count)
                {
                    continue;
                }

                if (direction == "first")
                {
                    coffees.RemoveRange(0, count);
                }
                else if (direction == "last")
                {
                    for (int j = 0; j < count; j++)
                    {
                        coffees.RemoveAt(coffees.Count - 1);
                    }
                }
            }
            else if (command == "Prefer")
            {
                var index1 = int.Parse(args[1]);
                var index2 = int.Parse(args[2]);

                if (index1 < 0 || index1 >= coffees.Count)
                {
                    continue;
                }

                if (index2 < 0 || index2 >= coffees.Count)
                {
                    continue;
                }

                var temp = coffees[index1];
                coffees[index1] = coffees[index2];
                coffees[index2] = temp;
            }
            else if (command == "Reverse")
            {
                coffees.Reverse();
            }
        }

        Console.WriteLine("Coffees:");
        Console.WriteLine(string.Join(" ", coffees));
    }
}