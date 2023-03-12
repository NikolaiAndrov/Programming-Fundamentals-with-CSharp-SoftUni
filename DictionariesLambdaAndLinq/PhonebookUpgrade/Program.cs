using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var commandLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var dict = new SortedDictionary<string, string>();
     
        while (commandLine[0] != "END")
        {

            if (commandLine[0] == "A")
            {
                var name = commandLine[1];
                var number = commandLine[2];
                dict[name] = number;
            }
            else if (commandLine[0] == "S")
            {
                if (dict.ContainsKey(commandLine[1]))
                {
                    foreach (var item in dict)
                    {
                        if (item.Key == commandLine[1])
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Contact {commandLine[1]} does not exist.");
                }
            }
            else if (commandLine[0] == "ListAll")
            {
                foreach (var item in dict)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }


            commandLine = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}