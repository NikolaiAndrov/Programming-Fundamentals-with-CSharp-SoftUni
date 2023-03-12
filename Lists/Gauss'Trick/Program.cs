using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse) 
            .ToList();

        var result = new List<int>();

        for (int i = 0; i < nums.Count / 2; i++)
        {
            var sum = nums[i] + nums[nums.Count - 1 - i];
            result.Add(sum);
        }

        if (nums.Count % 2 != 0)
        {
            var currentNum = nums[nums.Count / 2];
            result.Add(currentNum);
        }

        Console.WriteLine(string.Join(" ", result));
    }
}