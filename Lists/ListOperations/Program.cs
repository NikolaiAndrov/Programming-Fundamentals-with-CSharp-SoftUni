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

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];

            if (command == "Add")
            {
                var num = int.Parse(args[1]);
                nums.Add(num);
            }
            else if (command == "Insert")
            {
                var num = int.Parse(args[1]);
                var index = int.Parse(args[2]);

                if (index < 0 || index >= nums.Count)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }

                nums.Insert(index, num);
            }
            else if (command == "Remove")
            {
                var index = int.Parse(args[1]);

                if (index < 0 || index >= nums.Count)
                {
                    Console.WriteLine("Invalid index");
                    continue;
                }

                nums.RemoveAt(index);
            }
            else if (command == "Shift")
            {
                var direction = args[1];
                var count = int.Parse(args[2]);
                
                if (direction == "left")
                {
                    ShiftLeft(nums, count);
                }
                else if (direction == "right")
                {
                    ShiftRight(nums, count);
                }
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }

    static void ShiftRight(List<int> nums, int count)
    {
        int shiftCount = count % nums.Count;

        for (int i = 0; i < shiftCount; i++)
        {
            int num = nums[nums.Count - 1];
            nums.RemoveAt(nums.Count - 1);
            nums.Insert(0, num);
        }
    }
    static void ShiftLeft(List<int> nums, int count)
    {
        int shiftCount = count % nums.Count;

        for (int i = 0; i < shiftCount; i++)
        {
            int num = nums[0];
            nums.RemoveAt(0);
            nums.Add(num);
        }
    }
}
