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
            .ToArray();

        var result = new int[nums.Length];

        var count = 1;
        var currentCount = 1;
        var currentSequence = new List<int>();
        var longestSequence = new List<int>();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            var n1 = nums[i];
            var n2 = nums[i + 1];

            if (n1 < n2)
            {
                currentCount++;

                currentSequence.Add(n1);
                currentSequence.Add(n2);

                if (currentCount > count)
                {
                    count = currentCount;
                    longestSequence = currentSequence.ToList();
                }
            }
            else
            {
                currentSequence.Clear();
                currentCount = 1;
            }
        }

        Console.WriteLine(string.Join(" ", longestSequence.Distinct()));
    }
}