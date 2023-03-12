using System;
using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        var nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var num = 0;
        var count = 0;

        foreach (var n in nums)
        {
            var currentCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (n == nums[i])
                {
                    currentCount++;

                    if (currentCount > count)
                    {
                        count = currentCount;
                        num = n;
                    }
                }
            }
        }

        Console.WriteLine(num);
    }
}