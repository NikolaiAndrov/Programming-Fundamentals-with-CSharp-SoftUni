using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                var sum = nums[i] + nums[j];

                if (sum == n)
                {
                    Console.WriteLine($"{nums[i]} {nums[j]}");
                }
            }
        }
    }
}