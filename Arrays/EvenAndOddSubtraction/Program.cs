using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var evenSum = nums.Where(x => x % 2 == 0).Sum();
        var oddSum = nums.Where(x => x % 2 != 0).Sum();
        var diff = evenSum - oddSum;

        Console.WriteLine(diff);
    }
}