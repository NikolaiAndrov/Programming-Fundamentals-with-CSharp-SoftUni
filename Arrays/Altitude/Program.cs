using System;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        var commands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        double altitude = double.Parse(commands[0]);
        string command = "";
        double currentaltitude = 0;
        bool gotThrough = true;

        for (int i = 1; i < commands.Length; i++)
        {

            if(i % 2 != 0) 
            {
                command = commands[i];
                continue;
            }
            else if (i % 2 == 0)
            {
                currentaltitude = double.Parse(commands[i]);
            }

            if(command == "up")
            {
                altitude += currentaltitude;
            }
            else if (command == "down")
            {
                altitude -= currentaltitude;
                if(altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    gotThrough = false;
                    break;
                }
            }
        }
        if(gotThrough)
        {
            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
        
    }
}