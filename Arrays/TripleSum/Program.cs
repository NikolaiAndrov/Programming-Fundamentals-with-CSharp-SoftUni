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

        var isFound = false;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                var sum = nums[i] + nums[j];
               
                for (int l = 0; l < nums.Length; l++)
                {
                    if (sum == nums[l])
                    {
                        isFound = true;
                        Console.WriteLine($"{nums[i]} + {nums[j]} == {sum}");
                        break;
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}