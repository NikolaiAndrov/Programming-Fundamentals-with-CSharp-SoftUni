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

        if (nums.Length % 2 != 0)
        {
            if (nums.Length == 1)
            {
                Console.WriteLine("{ " + nums[0] + " }");
            }
            else
            {
                int midElement = nums.Length / 2;
                Console.WriteLine("{ " + nums[midElement - 1] + ", " + nums[midElement] + ", " + nums[midElement + 1] + " }");
            }
        }
        else if (nums.Length % 2 == 0)
        {
            int element = nums.Length / 2;
            Console.WriteLine("{ " + nums[element - 1] + ", " + nums[element] + " }");
        }
    }
}