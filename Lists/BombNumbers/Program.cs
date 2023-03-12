using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var bomb = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var bombNumber = bomb[0];
        var power = bomb[1];

        while (nums.Contains(bombNumber))
        {
            var startIndex = nums.IndexOf(bombNumber) - power;
            var endIndex = nums.IndexOf(bombNumber) + power;

            if (startIndex < 0)
            {
                startIndex = 0;
            }

            if (endIndex >= nums.Count)
            {
                endIndex = nums.Count - 1;
            }

            var lenght = (endIndex - startIndex) + 1;
            nums.RemoveRange(startIndex, lenght);
        }

        Console.WriteLine(nums.Sum());
    }
}
