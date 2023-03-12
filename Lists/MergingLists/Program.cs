using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var firstCollection = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse) 
            .ToList();

        var secondCollection = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var result = new List<int>();

        var n = Math.Min(firstCollection.Count, secondCollection.Count);

        for (int i = 0; i < n; i++)
        {
            result.Add(firstCollection[i]);
            result.Add(secondCollection[i]);
        }

        if (firstCollection.Count > secondCollection.Count)
        {
            for (int i = n; i < firstCollection.Count; i++)
            {
                result.Add(firstCollection[i]);
            }
        }
        else if (secondCollection.Count > firstCollection.Count)
        {
            for (int i = n; i < secondCollection.Count; i++)
            {
                result.Add(secondCollection[i]);
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}