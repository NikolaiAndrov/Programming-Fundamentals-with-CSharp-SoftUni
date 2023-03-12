using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var products = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var product = Console.ReadLine();
            products.Add(product);
        }

        products.Sort();

        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{products[i]}");
        }
    }
}