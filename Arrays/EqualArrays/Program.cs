using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var nums1 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var nums2 = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int n = Math.Min(nums1.Length, nums2.Length);

        for (int i = 0; i < n; i++)
        {
            if (nums1[i] != nums2[i])
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                return;
            }
        }

        Console.WriteLine($"Arrays are identical. Sum: {nums1.Sum()}");
    }
}