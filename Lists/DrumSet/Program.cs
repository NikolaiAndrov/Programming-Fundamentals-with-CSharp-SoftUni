internal class Program
{
    private static void Main()
    {
        var savings = double.Parse(Console.ReadLine());

        var drumSet = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var initialQuality = drumSet.ToList();

        string input;

        while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
        {
            var hitPower = int.Parse(input);

            for (int i = 0; i < drumSet.Count; i++)
            {
                drumSet[i] -= hitPower;

                if (drumSet[i] <= 0)
                {
                    var priceNeeded = initialQuality[i] * 3;

                    if (priceNeeded <= savings)
                    {
                        drumSet[i] = initialQuality[i];
                        savings -= priceNeeded;
                    }
                    else
                    {
                        drumSet.RemoveAt(i);
                        initialQuality.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ", drumSet));
        Console.WriteLine($"Gabsy has {savings:F2}lv.");
    }
}