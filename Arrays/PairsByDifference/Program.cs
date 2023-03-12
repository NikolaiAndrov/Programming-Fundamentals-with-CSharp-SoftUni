using System;
using System.Collections.Immutable;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var diff = int.Parse(Console.ReadLine());
        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var n1 = nums[i];

            for (int j = 0; j < i; j++)
            {
                var n2 = nums[j];

                if (n1 - n2 == diff || n2 - n1 == diff)
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}