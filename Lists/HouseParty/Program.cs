using System;
using System.Linq;
using System.Collections.Concurrent; 
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var guestList = new List<string>();

        for (int i = 0; i < n; i++)
        {
            var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var name = commands[0];

            if (commands.Length == 3)
            {
                if (!guestList.Contains(name))
                {
                    guestList.Add(name);
                }
                else
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
            }
            else if (commands.Length == 4)
            {
                if (guestList.Contains(name))
                {
                    guestList.Remove(name);
                }
                else
                {
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
        }
        foreach (var guest in guestList)
        {
            Console.WriteLine(guest);
        }
    }
}