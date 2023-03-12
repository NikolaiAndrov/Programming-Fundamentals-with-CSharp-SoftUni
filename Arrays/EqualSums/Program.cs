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

        bool equalSum = false;

        for (int i = 0; i < nums.Length; i++)
        {
            var leftSum = 0;
            var rightSum = 0;

            for (int l = 0; l < i; l++)
            {
                leftSum += nums[l];
            }

            for (int r = i + 1; r < nums.Length; r++)
            {
                rightSum += nums[r];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                equalSum = true;
            }
        }

        if (!equalSum)
        {
            Console.WriteLine("no");
        }
    }
}