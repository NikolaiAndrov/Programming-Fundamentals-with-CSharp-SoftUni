using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var bestSequence = new int[n];

        var input = Console.ReadLine();

        var maxLength = 1;
        var bestStartIndex = 0;
        var bestSum = 0;
        var sampleCount = 0;
        var counter = 0;

        while (input != "Clone them!")
        {

            var currentSequence = input
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var length = 1;
            var bestLength = 1;
            var startIndex = 0;
            var currentSum = currentSequence.Sum();
            counter++;

            for (int i = 0; i < currentSequence.Length - 1; i++)
            {
                if (currentSequence[i] == currentSequence[i + 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    startIndex = i;
                }
            }

            if (bestLength > maxLength)
            {
                maxLength = bestLength;
                bestStartIndex = startIndex;
                bestSum = currentSum;
                sampleCount = counter;
                bestSequence = currentSequence.ToArray();
            }
            else if (bestLength == maxLength)
            {
                if (startIndex < bestStartIndex)
                {
                    maxLength = bestLength;
                    bestStartIndex = startIndex;
                    bestSum = currentSum;
                    sampleCount = counter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (startIndex == bestStartIndex)
                {
                    if (currentSum > bestSum)
                    {
                        maxLength = bestLength;
                        bestStartIndex = startIndex;
                        bestSum = currentSum;
                        sampleCount = counter;
                        bestSequence = currentSequence.ToArray();
                    }
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Best DNA sample {sampleCount} with sum: {bestSum}.");
        Console.WriteLine($"{string.Join(" ", bestSequence)}");
    }
}