using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var target = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string input = Console.ReadLine();
        int shotsCount = 0;

        while (input != "End")
        {
            int index = int.Parse(input);

            if (index < 0 || index >= target.Count)
            {
                input = Console.ReadLine();
                continue;
            }

            int shotNumber = target[index];

            if (shotNumber == -1)
            {
                input = Console.ReadLine();
                continue;
            }
            else
            {
                target[index] = -1;
                shotsCount++;
            }

            for (int i = 0; i < target.Count; i++)
            {
                if (target[i] != -1)
                {
                    if (target[i] > shotNumber)
                    {
                        target[i] -= shotNumber;
                    }
                    else if (target[i] <= shotNumber)
                    {
                        target[i] += shotNumber;
                    }
  
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Shot targets: {shotsCount} -> {string.Join(" ", target)}");
    }
}