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
            .OrderByDescending(x => x)
            .ToList();

        double avg = nums.Average();

        nums.RemoveAll(x => x <= avg);

        if (nums.Count > 5)
        {
            int diff = nums.Count - 5;

            for (int i = 0; i < diff; i++)
            {
                int lastIndex = nums.Count - 1;
                nums.RemoveAt(lastIndex);
            }
        }

        if (nums.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}