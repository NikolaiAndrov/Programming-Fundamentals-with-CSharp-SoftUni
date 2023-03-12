using System;
public class Program
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        double dailyPlunder = double.Parse(Console.ReadLine());
        double expectedPlunder = double.Parse(Console.ReadLine());
        double totalPlunder = 0;

        for (int i = 1; i <= days; i++)
        {
            totalPlunder += dailyPlunder;

            if (i % 3 == 0)
            {
                double add = dailyPlunder * 0.5;
                totalPlunder += add;
            }

            if (i % 5 == 0)
            {
                double ext = totalPlunder * 0.3;
                totalPlunder -= ext;
            }
        }

        if (totalPlunder >= expectedPlunder)
        {
            Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
        }
        else
        {
            double percent = (totalPlunder/ expectedPlunder) * 100;
            Console.WriteLine($"Collected only {percent:F2}% of the plunder.");
        }
    }
}