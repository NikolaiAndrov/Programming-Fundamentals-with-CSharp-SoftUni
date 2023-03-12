using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var wordsInput = Console.ReadLine()
            .ToLower()
            .Split(' ');

        var wordsCount = new Dictionary<string, int>();

        foreach (var word in wordsInput)
        {
            if (!wordsCount.ContainsKey(word))
            {
                wordsCount[word] = 0;
            }

            wordsCount[word]++;
        }

        var oddCountWords = new List<string>();

        foreach (var word in wordsCount)
        {
            if (word.Value % 2 != 0)
            {
                oddCountWords.Add(word.Key);
            }
        }

        Console.WriteLine(string.Join(", ", oddCountWords));
    }
}