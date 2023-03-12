using System;
using System.Linq;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        var StringNumbers = Console.ReadLine()
            .Split(' ')
            .ToList();

        var reversedNumbers = new List<int>();
        
        foreach (var item in StringNumbers)
        {
            string currentNumString = "";

            for (int i = item.Length - 1; i >= 0; i--)
            {
                currentNumString += item[i];

            }

            reversedNumbers.Add(int.Parse(currentNumString));
          
        }

        Console.WriteLine(string.Join(" ", reversedNumbers.Sum()));
    }
}