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

        var sum = 0;

        while (nums.Count > 0)
        {
            var index = int.Parse(Console.ReadLine());

            if (index < 0)
            {
                NegativeIndex(nums, ref sum);
                continue;
            }

            if (index >= nums.Count)
            {
                OverLengthIndex(nums, ref sum);
                continue;
            }

            IndexInRange(nums, index, ref sum);
        }

        Console.WriteLine(sum);
    }

    static void IndexInRange(List<int> nums, int index, ref int sum)
    {
        var currentNum = nums[index];
        sum += currentNum;
        nums.RemoveAt(index);

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] <= currentNum)
            {
                nums[i] += currentNum;
            }
            else if (nums[i] > currentNum)
            {
                nums[i] -= currentNum;
            }
        }
    }
    static void OverLengthIndex(List<int> nums, ref int sum)
    {
        var currentNum = nums[nums.Count - 1];
        sum += currentNum;
        nums[nums.Count - 1] = nums[0];

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] <= currentNum)
            {
                nums[i] += currentNum;
            }
            else if (nums[i] > currentNum)
            {
                nums[i] -= currentNum;
            }
        }
    }
    static void NegativeIndex(List<int> nums, ref int sum)
    {
        var currentNum = nums[0];
        sum += currentNum;
        nums[0] = nums[nums.Count - 1];

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] <= currentNum)
            {
                nums[i] += currentNum;
            }
            else if (nums[i] > currentNum)
            {
                nums[i] -= currentNum;
            }
        }
    }
}
