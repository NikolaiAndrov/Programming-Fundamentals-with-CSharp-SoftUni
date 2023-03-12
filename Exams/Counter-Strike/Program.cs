using System;
public class Program
{
    public static void Main()
    {
        int initialEnergy = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int winCount = 0;

        while (input != "End of battle")
        {
            int distance = int.Parse(input);

            if (initialEnergy >= distance)
            {
                initialEnergy -= distance;
                winCount++;

                if (winCount % 3 == 0)
                {
                    initialEnergy += winCount;
                }
            }
            else
            {
                Console.WriteLine($"Not enough energy! Game ends with {winCount} won battles and {initialEnergy} energy");
                return;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Won battles: {winCount}. Energy left: {initialEnergy}");
    }
}