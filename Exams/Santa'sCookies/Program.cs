using System;

namespace ComputerStore
{
    internal class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            int singleCookieGrams = 25;
            int cup = 140;
            int smallSpoon = 10;
            int bigSpoon = 20;
            int cookiesPerBox = 5;

            double totalBoxes = 0;

            for (int i = 0; i < n; i++)
            {
                int flour = 0;
                int sugar = 0;
                int cocoa = 0;

                int currentFlour = int.Parse(Console.ReadLine());
                flour += currentFlour;
                int currentSugar = int.Parse(Console.ReadLine());
                sugar += currentSugar;
                int currentCocoa = int.Parse(Console.ReadLine());
                cocoa += currentCocoa;

                int flourCups = flour / cup;
                int sugarSpoons = sugar / bigSpoon;
                int cocoaSpoons = cocoa / smallSpoon;
                int min = GetMin(flourCups, sugarSpoons, cocoaSpoons);

                if (min <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    double totalCookies = Math.Floor((double)(cup + smallSpoon + bigSpoon) * min / singleCookieGrams);
                    double boxes = Math.Floor(totalCookies / cookiesPerBox);
                    totalBoxes += boxes;
                    Console.WriteLine($"Boxes of cookies: {boxes}");
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }

        static int GetMin(int n1, int n2, int n3)
        {
            int min = n1;

            if (n2 < min)
            {
                min = n2;
            }

            if (n3 < min)
            {
                min = n3;
            }

            return min;
        }
    }
}
