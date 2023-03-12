using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var fieldSize = int.Parse(Console.ReadLine());

        var field = new int[fieldSize];

        var initialPlaces = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        for (int i = 0; i < initialPlaces.Length; i++)
        {
            var index = initialPlaces[i];

            if (index >= 0 && index < field.Length)
            {
                field[index] = 1;
            }
        }

        var input = Console.ReadLine();

        while (input != "end")
        {
            var args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var startIndex = int.Parse(args[0]);
            var endIndex = int.Parse(args[2]);
            var direction = args[1];

            if (startIndex < 0 || startIndex >= field.Length)
            {
                input = Console.ReadLine();
                continue;
            }

            if (field[startIndex] == 0)
            {
                input = Console.ReadLine();
                continue;
            }

            field[startIndex] = 0;

            if (direction == "left")
            {
                endIndex *= - 1;
            }

            var indexToGo = startIndex + endIndex;

            while (indexToGo >= 0 && indexToGo < field.Length && field[indexToGo] == 1)
            {
                indexToGo += endIndex;
            }

            if (indexToGo >= 0 && indexToGo < field.Length) 
            {
                field[indexToGo] = 1;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }
}