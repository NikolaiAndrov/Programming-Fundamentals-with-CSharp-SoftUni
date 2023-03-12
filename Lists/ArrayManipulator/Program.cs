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

        string input;

        while ((input = Console.ReadLine()) != "print")
        {
            var args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];

            if (command == "add")
            {
                var index = int.Parse(args[1]);
                var element = int.Parse(args[2]);
                nums.Insert(index, element);
            }
            else if (command == "addMany")
            {
                AddMany(nums, args);
            }
            else if (command == "contains")
            {
                var element = int.Parse(args[1]);

                if (nums.Contains(element))
                {
                    Console.WriteLine(nums.IndexOf(element));
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
            else if (command == "remove")
            {
                var index = int.Parse(args[1]);
                nums.RemoveAt(index);
            }
            else if (command == "shift")
            {
                var count = int.Parse(args[1]);
                Shift(nums, count);
            }
            else if (command == "sumPairs")
            {
                SumPairs(nums);
            }
        }

        Console.WriteLine($"[{string.Join(", ", nums)}]");
    }

    static void SumPairs(List<int> nums)
    {
        for (int i = 0; i < nums.Count - 1; i++)
        {
            nums[i] += nums[i + 1];
            nums.RemoveAt(i + 1);
        }
    }
    static void Shift(List<int> nums, int count)
    {
        var shifts = count % nums.Count;

        for (int i = 0; i < shifts; i++)
        {
            var num = nums[0];

            for (int j = 1; j < nums.Count; j++)
            {
                nums[j - 1] = nums[j]; 
            }

            nums[nums.Count - 1] = num;
        }
    }
    static void AddMany(List<int> nums, string[] args)
    {
        var elements = new int[args.Length - 2];
        var currentIndex = 0;

        for (int i = 2; i < args.Length; i++)
        {
            elements[currentIndex] = int.Parse(args[i]);
            currentIndex++;
        }

        var index = int.Parse(args[1]);
        nums.InsertRange(index, elements);
    }
}
