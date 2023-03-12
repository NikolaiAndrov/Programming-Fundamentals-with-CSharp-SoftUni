using System;
public class Program
{
    public static void Main()
    {
        double foodQuantity = double.Parse(Console.ReadLine());
        double hayQuantity = double.Parse(Console.ReadLine());
        double coverQuantity = double.Parse(Console.ReadLine());
        double weight = double.Parse(Console.ReadLine());

        double food = foodQuantity * 1000;
        double hay = hayQuantity * 1000;
        double cover = coverQuantity * 1000;
        weight *= 1000;

        for (int i = 1; i <= 30; i++)
        {
            food -= 300;

            if (i % 2 == 0)
            {
                double hayNeeded = food * 0.05;
                hay -= hayNeeded;
            }

            if (i % 3 == 0)
            {
                double coverNeeded = weight / 3;
                cover -= coverNeeded;
            }

            if (food <= 0 || hay <= 0 || cover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
                return;
            }
        }

        Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:F2}, Hay: {hay / 1000:F2}, Cover: {cover / 1000:F2}.");
    }
}