using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var houses = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var position = 0;

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var command = args[0];

            if (command == "Forward")
            {
                var steps = int.Parse(args[1]);

                if (position + steps >= houses.Count)
                {
                    continue;
                }

                position += steps;
                houses.RemoveAt(position);
            }
            else if (command == "Back")
            {
                var steps = int.Parse(args[1]);

                if (position - steps < 0)
                {
                    continue;
                }

                position -= steps;
                houses.RemoveAt(position);
            }
            else if (command == "Gift")
            {
                var index = int.Parse(args[1]);
                var houseNumber = int.Parse(args[2]);

                if (index < 0 || index >= houses.Count)
                {
                    continue;
                }

                houses.Insert(index, houseNumber);
                position = index;
            }
            else if (command == "Swap")
            {
                var house1 = int.Parse(args[1]);
                var house2 = int.Parse(args[2]);

                if (!houses.Contains(house1) || !houses.Contains(house2))
                {
                    continue;
                }

                SwapHouses(houses, house1, house2);
            }
        }

        Console.WriteLine($"Position: {position}");
        Console.WriteLine(string.Join(", ", houses));
    }

    static void SwapHouses(List<int> houses, int house1, int house2)
    {
        var index1 = houses.IndexOf(house1);
        var index2 = houses.IndexOf(house2);
        houses[index1] = house2;
        houses[index2] = house1;
    }
}