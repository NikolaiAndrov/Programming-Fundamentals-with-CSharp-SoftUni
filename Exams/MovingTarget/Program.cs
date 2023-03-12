using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var targets = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string input = Console.ReadLine();

        while (input != "End")
        {
            var args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (command == "Shoot")
            {
                int index = int.Parse(args[1]);

                if (index < 0 || index >= targets.Count)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int power = int.Parse(args[2]);
                targets[index] -= power;

                if (targets[index] <= 0)
                {
                    targets.RemoveAt(index);
                }
            }
            else if (command == "Add")
            {
                int index = int.Parse(args[1]);

                if (index < 0 || index >= targets.Count)
                {
                    Console.WriteLine("Invalid placement!");
                    input = Console.ReadLine();
                    continue;
                }

                int value = int.Parse(args[2]);
                targets.Insert(index, value);
            }
            else if (command == "Strike")
            {
                int index = int.Parse(args[1]);
                int radius = int.Parse(args[2]);

                int iterations = radius * 2 + 1;
                int delIndex = index - radius;
                int maxIndex = index + radius;

                if (delIndex < 0 || maxIndex >= targets.Count)
                {
                    Console.WriteLine("Strike missed!");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= iterations; i++)
                {
                    targets.RemoveAt(delIndex);
                }

            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join("|", targets));
    }
}