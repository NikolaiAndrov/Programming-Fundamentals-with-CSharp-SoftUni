using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var firstElements = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var secondElements = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var commonElements = new string[secondElements.Length];
        var index = 0;

        for (int i = 0; i < secondElements.Length; i++)
        {
            var searchedElement = secondElements[i];

            for (int j = 0; j < firstElements.Length; j++)
            {
                var currentElement = firstElements[j];

                if (searchedElement == currentElement)
                {
                    commonElements[index] = currentElement;
                    index++;
                }
            }
        }

        Console.WriteLine(string.Join(" ", commonElements));
    }
}