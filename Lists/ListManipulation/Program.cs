using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var inputLine = Console.ReadLine();
        bool isChanged = false;

        while (inputLine != "end")
        {
            var arguments = inputLine.Split();
            var command = arguments[0];
            if (command == "Add")
            {
                var num = int.Parse(arguments[1]);
                nums.Add(num);
                isChanged = true;
            }
            else if (command == "Remove")
            {
                var num = int.Parse(arguments[1]);
                nums.Remove(num);
                isChanged = true;
            }
            else if (command == "RemoveAt")
            {
                var index = int.Parse(arguments[1]);
                nums.RemoveAt(index);
                isChanged = true;
            }
            else if (command == "Insert")
            {
                var num = int.Parse(arguments[1]);
                var index = int.Parse(arguments[2]);
                nums.Insert(index, num);
                isChanged = true;
            }
            else if (command == "Contains")
            {
                var num = int.Parse(arguments[1]);
                if (nums.Contains(num))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
            else if (command == "PrintEven")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 == 0)));
            }
            else if (command == "PrintOdd")
            {
                Console.WriteLine(string.Join(" ", nums.Where(x => x % 2 != 0)));
            }
            else if (command == "GetSum")
            {
                Console.WriteLine(nums.Sum());
            }
            else if (command == "Filter")
            {
                var condition = arguments[1];
                var num = int.Parse(arguments[2]);

                if (condition == "<")
                {
                    Console.WriteLine(string.Join(" ", nums.Where(x => x < num)));
                }
                else if (condition == ">")
                {
                    Console.WriteLine(string.Join(" ", nums.Where(x => x > num)));
                }
                else if (condition == ">=")
                {
                    Console.WriteLine(string.Join(" ", nums.Where(x => x >= num)));
                }
                else if (condition == "<=")
                {
                    Console.WriteLine(string.Join(" ", nums.Where(x => x <= num)));
                }
            }

            inputLine = Console.ReadLine();
        }
        if (isChanged)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}