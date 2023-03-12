using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (nums.Count > 1)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                var currentNum = nums[i] + nums[i + 1];
                nums.RemoveAt(i);
                nums.Insert(i, currentNum);
            }

            var lastIndex = nums.Count - 1;
            nums.RemoveAt(lastIndex);
        }

        Console.WriteLine(nums[0]);
    }
}