using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var journal = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var input = Console.ReadLine();

        while (input != "Craft!")
        {
            var args = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];

            if (command == "Collect")
            {
                var item = args[1];

                if (!journal.Contains(item))
                {
                    journal.Add(item);
                }
            }
            else if (command == "Drop")
            {
                var item = args[1];

                if (journal.Contains(item))
                {
                    journal.Remove(item);
                }
            }
            else if (command == "Combine Items")
            {
                var items = args[1].Split(":");
                var oldItem = items[0];
                var newItem = items[1];

                if (journal.Contains(oldItem))
                {
                    var index = journal.IndexOf(oldItem) + 1;
                    journal.Insert(index, newItem);
                }
            }
            else if (command == "Renew")
            {
                var item = args[1];

                if (journal.Contains(item))
                {
                    journal.Remove(item);
                    journal.Add(item);
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", journal));
    }
}