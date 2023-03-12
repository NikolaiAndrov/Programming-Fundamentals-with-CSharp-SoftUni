using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        string resource = Console.ReadLine();

        var dict = new Dictionary<string, long>();

        while (resource != "stop")
        {
            long quantity = long.Parse(Console.ReadLine());

            if (!dict.ContainsKey(resource))
            {
                dict[resource] = quantity;
            }
            else
            {
                dict[resource] += quantity;
            }
            

            resource = Console.ReadLine();
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}