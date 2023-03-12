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

        var sum = new int[nums.Length];

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var lastElement = nums[nums.Length - 1];

            for (int j = nums.Length - 1; j > 0; j--)
            {
                nums[j] = nums[j - 1];
            }

            nums[0] = lastElement;

            for (int l = 0; l < nums.Length; l++)
            {
                sum[l] += nums[l];
            }
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}