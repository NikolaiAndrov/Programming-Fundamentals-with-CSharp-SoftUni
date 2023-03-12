using System;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        var targetCoordinates = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
        double targetX = double.Parse(targetCoordinates[0]);
        double targetY = double.Parse(targetCoordinates[1]);
        var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double x = 0;
        double y = 0;
        double currentNum = 0;
        string currentCommand = "";

        for (int i = 0; i < commands.Length; i++)
        {
            if(i % 2 == 0)
            {
                currentCommand = commands[i];
                continue;
            }
            else if (i % 2 != 0)
            {
                currentNum = double.Parse(commands[i]);
            }
                if (currentCommand == "up")
                {
                    y += currentNum;
                }
                else if (currentCommand == "down")
                {
                    y -= currentNum;
                }
                else if (currentCommand == "left")
                {
                    x -= currentNum;
                }
                else if (currentCommand == "right")
                {
                    x += currentNum;
                }
        }
        Console.WriteLine($"firing at [{x}, {y}]");

        if (x == targetX && y == targetY)
        {
            Console.WriteLine("got 'em!");
        }
        else
        {
            Console.WriteLine("better luck next time...");
        }
    }
}