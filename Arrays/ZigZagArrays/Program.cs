using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var firstNums = new int[n];
        var secondNums = new int[n];

        for (int i = 0; i < n; i++)
        {
            var nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var currentNum1 = int.Parse(nums[0]);
            var currentNum2 = int.Parse(nums[1]);

            if (i % 2 == 0)
            {
                firstNums[i] = currentNum1;
                secondNums[i] = currentNum2;
            }
            else
            {
                firstNums[i] = currentNum2;
                secondNums[i] = currentNum1;
            }
        }

        Console.WriteLine(string.Join(" ", firstNums));
        Console.WriteLine(string.Join(" ", secondNums));
    }
}