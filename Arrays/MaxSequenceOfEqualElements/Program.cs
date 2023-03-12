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

        var counter = 1;
        var currentCounter = 1;
        var num = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                currentCounter++;

                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    num = nums[i];
                }
            }
            else
            {
                currentCounter = 1;
            }      
        }

        for (int i = 0; i < counter; i++)
        {
            Console.Write(num + " ");
        }
    }
}