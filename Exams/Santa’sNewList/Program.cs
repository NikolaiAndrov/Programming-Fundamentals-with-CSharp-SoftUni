using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var children = new Dictionary<string, int>();
        var toys = new Dictionary<string, int>();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split("->", StringSplitOptions.RemoveEmptyEntries);

            if (args[0] == "Remove")
            {
                var nameToRemove = args[1];

                if (children.ContainsKey(nameToRemove))
                {
                    children.Remove(nameToRemove);
                }

                continue;
            }

            var name = args[0];
            var toy = args[1];
            var toysCount = int.Parse(args[2]);

            if (!children.ContainsKey(name))
            {
                children[name] = toysCount;
            }
            else
            {
                children[name] += toysCount;
            }

            if (!toys.ContainsKey(toy))
            {
                toys[toy] = toysCount;
            }
            else
            {
                toys[toy] += toysCount;
            }
        }

        Console.WriteLine("Children:");

        foreach (var name in children.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{name.Key} -> {name.Value}");
        }

        Console.WriteLine("Presents:");

        foreach (var toy in toys)
        {
            Console.WriteLine($"{toy.Key} -> {toy.Value}");
        }
    }
}