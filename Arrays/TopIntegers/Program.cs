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

        for (int i = 0; i < nums.Length; i++)
        {
            var checkedNum = nums[i];
            bool isTopInt = true;

            for (int j = i + 1; j < nums.Length; j++)
            {
                var currentNum = nums[j];

                if (checkedNum <= currentNum)
                {
                    isTopInt = false;
                }
            }

            if (isTopInt)
            {
                Console.Write(checkedNum + " ");
            }
        }
    }
}