using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();

        foreach (var num in nums)
        {
            int rounded = (int)Math.Round(num, MidpointRounding.AwayFromZero);
            Console.WriteLine($"{num} => {rounded}");
        }
        
    }
}