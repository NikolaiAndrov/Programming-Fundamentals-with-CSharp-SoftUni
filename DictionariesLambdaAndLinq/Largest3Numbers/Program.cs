using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList();

        Console.WriteLine(string.Join(" ", numbers));
    }
}