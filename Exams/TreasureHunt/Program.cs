using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var treasure = Console.ReadLine()
            .Split("|")
            .ToList();

        var input = Console.ReadLine();

        while (input != "Yohoho!")
        {
            var args = input.Split();
            var commands = args[0];

            if (commands == "Loot")
            {
                for (int i = 1; i < args.Length; i++)
                {
                    var item = args[i];

                    if (!treasure.Contains(item))
                    {
                        treasure.Insert(0, item);
                    }
                }
            }
            else if (commands == "Drop")
            {
                var index = int.Parse(args[1]);

                if (index >= 0 && index < treasure.Count)
                {
                    var item = treasure[index];
                    treasure.RemoveAt(index);
                    treasure.Add(item);
                }
            }
            else if (commands == "Steal")
            {
                var count = int.Parse(args[1]);
                var result = new List<string>();

                if (count > treasure.Count)
                {
                    count = treasure.Count;
                }

                for (int i = 0; i < count; i++)
                {
                    var lastIndex = treasure.Count - 1;
                    var lastItem = treasure[lastIndex];
                    result.Insert(0, lastItem);
                    treasure.RemoveAt(lastIndex);
                }

                if (result.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", result));
                }
            }

            input = Console.ReadLine();
        }

        if (treasure.Count == 0)
        {
            Console.WriteLine("Failed treasure hunt.");
        }
        else
        {
            double counter = 0;
            double allItems = treasure.Count;

            foreach (var item in treasure)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    counter++;
                }
            }

            double avg = counter / allItems;

            Console.WriteLine($"Average treasure gain: {avg:F2} pirate credits.");
        }
    }
}