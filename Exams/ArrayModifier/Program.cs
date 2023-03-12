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
            .ToList();

        string input = Console.ReadLine();

        while (input != "end")
        {
            var args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = args[0];
            

            if (command == "swap")
            {
                int index1 = int.Parse(args[1]);
                int index2 = int.Parse(args[2]);

                int num1 = nums[index1];
                int num2 = nums[index2];
                int temp = nums[index1];
                nums[index1] = num2;
                nums[index2] = temp;

            }
            else if (command == "multiply")
            {
                int index1 = int.Parse(args[1]);
                int index2 = int.Parse(args[2]);

                nums[index1] = nums[index1] * nums[index2];
            }
            else if (command == "decrease")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    nums[i] -= 1;
                }
            }
  
            input = Console.ReadLine();
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}