using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse) 
            .ToList();

        var operatingNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var elaboratedNumbers = new List<int>();

        int numbersToTake = operatingNumbers[0];
        int numbersToDelete = operatingNumbers[1];
        int numberToFind = operatingNumbers[2];

        for (int i = numbersToDelete; i < numbersToTake; i++)
        {
            elaboratedNumbers.Add(numbers[i]);
        }

        if (elaboratedNumbers.Contains(numberToFind))
        {
            Console.WriteLine("YES!");
        }
        else 
        {
            Console.WriteLine("NO!");
        }
    }
}