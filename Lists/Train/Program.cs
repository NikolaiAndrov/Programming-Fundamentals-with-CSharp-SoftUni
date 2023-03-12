using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        var train = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse) 
            .ToList();

        var capacity = int.Parse(Console.ReadLine());
        var commands = Console.ReadLine().Split(' ', StringSplitOptions.TrimEntries);

        while (commands[0] != "end")
        {
            if (commands[0] == "Add")
            {
                var num = int.Parse(commands[1]);
                train.Add(num);
            }
            else
            {
                var num = int.Parse(commands[0]);

                for (int i = 0; i < train.Count; i++)
                {
                    var wagon = train[i] + num;

                    if (wagon <= capacity)
                    {
                        train[i] += num;
                        break;
                    }
                    
                }
            }

            commands = Console.ReadLine().Split(' ', StringSplitOptions.TrimEntries);
        }
        Console.WriteLine(string.Join(" ", train));
    }
}