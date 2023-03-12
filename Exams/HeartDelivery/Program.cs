using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split("@", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse) 
            .ToList();

        var input = Console.ReadLine().Split();
        var lastPosition = 0;
        var houseCount = 0;
        var index = 0;

        while (input[0] != "Love!")
        {
            var currentIndex = int.Parse(input[1]);
            index += currentIndex;
            
            if (index >= nums.Count)
            {
                index = 0;
            }

            lastPosition = index;

            if (nums[index] > 0)
            {
                nums[index] -= 2;

                if (nums[index] == 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }
            }
            else if (nums[index] == 0)
            {
                Console.WriteLine($"Place {index} already had Valentine's day.");
            }

            input = Console.ReadLine().Split();
        }

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > 0)
            {
                houseCount++;
            }
        }

        if (houseCount == 0)
        {
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            Console.WriteLine("Mission was successful.");
        }
        else
        {
            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            Console.WriteLine($"Cupid has failed {houseCount} places.");
        }
    }
}