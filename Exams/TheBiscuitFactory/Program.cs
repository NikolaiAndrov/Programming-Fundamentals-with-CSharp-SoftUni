using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var biscuitsPerDay = double.Parse(Console.ReadLine());
        var workers = double.Parse(Console.ReadLine());
        var competitor = long.Parse(Console.ReadLine());
        var totalBiscuits = 0.0;

        for (int i = 1; i <= 30; i++)
        {
            double totalPerDay = biscuitsPerDay * workers;

            if (i % 3 == 0)
            {
                totalPerDay *= 0.75;
            }

            totalBiscuits += Math.Floor(totalPerDay);
        }

        Console.WriteLine($"You have produced {totalBiscuits} biscuits for the past month.");

        if (totalBiscuits > competitor)
        {
            var diff = totalBiscuits - competitor;
            var percent = (diff / competitor) * 100;
            Console.WriteLine($"You produce {percent:F2} percent more biscuits.");
        }
        else if (competitor > totalBiscuits)
        {
            var diff = competitor - totalBiscuits;
            var percent = (diff / competitor) * 100;
            Console.WriteLine($"You produce {percent:F2} percent less biscuits.");
        }
    }
}