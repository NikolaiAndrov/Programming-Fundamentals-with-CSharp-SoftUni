using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        var nums = Console.ReadLine()
            .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse) 
            .ToList();

        var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        while (true)
        {
            string command = commands[0];

            if (command == "Delete")
            {
                int num = int.Parse(commands[1]);
                nums.RemoveAll(x => x == num); 
            }
            else if (command == "Insert")
            {
                int num = int.Parse(commands[1]);
                int index = int.Parse(commands[2]);
                nums.Insert(index, num);
            }
            else if (command == "Odd")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 != 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
                break;
            }
            else if (command == "Even")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] % 2 == 0)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
                break;
            }
            commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}