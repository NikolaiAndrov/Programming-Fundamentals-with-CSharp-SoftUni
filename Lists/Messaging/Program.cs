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
            .ToArray();

        var text = Console.ReadLine().ToList();

        var result = string.Empty;

        for (int i = 0; i < nums.Length; i++)
        {
            var currentNum = nums[i];
            var sum = SumOfDigits(currentNum);
            var index = sum % text.Count;
            result += text[index];
            text.RemoveAt(index);
        }

        Console.WriteLine(result);
    }

    static int SumOfDigits(int currentNum)
    {
        var sum = 0;

        while (currentNum > 0)
        {
            var lastNum = currentNum % 10;
            sum += lastNum;
            currentNum /= 10;
        }

        return sum;
    }
}
