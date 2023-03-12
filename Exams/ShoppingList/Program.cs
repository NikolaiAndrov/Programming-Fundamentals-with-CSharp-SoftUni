using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var groceries = Console.ReadLine()
            .Split("!", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input= Console.ReadLine();

        while (input != "Go Shopping!")
        {
            var args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];

            if (command == "Urgent")
            {
                string item = args[1];

                if (!groceries.Contains(item))
                {
                    groceries.Insert(0, item);
                }
            }
            else if (command == "Unnecessary")
            {
                string item = args[1];

                if (groceries.Contains(item))
                {
                    groceries.Remove(item);
                }
            }
            else if (command == "Correct")
            {
                string oldItem = args[1];
                string newItem = args[2];

                if (groceries.Contains(oldItem))
                {
                    int index = groceries.IndexOf(oldItem);
                    groceries[index] = newItem;
                }
            }
            else if (command == "Rearrange")
            {
                string item = args[1];

                if (groceries.Contains(item))
                {
                    groceries.Remove(item);
                    groceries.Add(item);
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", groceries));
    }
}