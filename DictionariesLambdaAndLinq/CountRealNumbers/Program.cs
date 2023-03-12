using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        var numsCount = new Dictionary<double, int>();

        foreach (var num in nums)
        {
            if (!numsCount.ContainsKey(num))
            {
                numsCount[num] = 0;
            }
            numsCount[num]++;
        }

        foreach (var num in numsCount.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}