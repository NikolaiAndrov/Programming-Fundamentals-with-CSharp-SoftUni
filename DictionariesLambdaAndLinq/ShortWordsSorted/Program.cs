using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .ToLower()
            .Split(new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .Where(w => w.Length < 5)
            .OrderBy(w => w)
            .ToList();

        Console.WriteLine(string.Join(", ", words));
    }
}