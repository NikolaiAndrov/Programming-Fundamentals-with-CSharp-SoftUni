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
        var rotations = n % nums.Length;

        for (int i = 0; i < rotations; i++)
        {
            var firstElement = nums[0];

            for (int j = 1; j < nums.Length; j++)
            {
                nums[j - 1] = nums[j];
            }

            nums[nums.Length - 1] = firstElement;
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}