using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        var commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

        while (commands[0] != "3:1")
        {

            if (commands[0] == "merge")
            {
                var startIndex = int.Parse(commands[1]);
                var endIndex = int.Parse(commands[2]);

                FixInvalidIndexes(words, ref startIndex, ref endIndex);

                MergeWords(words, startIndex, endIndex);
               
            }
            else if (commands[0] == "divide")
            {
                var index = int.Parse(commands[1]);
                var partitions = int.Parse(commands[2]);

                var word = words[index];

                var substringLength = word.Length / partitions;
                var lastSubstringLength = word.Length - ((partitions - 1) * substringLength);

                var partitionsList = new List<string>();

                for (int i = 0; i < partitions; i++)
                {
                    var desiredLength = substringLength;
                    if (i == partitions - 1)
                    {
                        desiredLength = lastSubstringLength;
                    }

                    var newPartitionArr = word
                        .Skip(i * substringLength)
                        .Take(desiredLength)
                        .ToArray();
                    var newPartition = string.Join("", newPartitionArr);
                    partitionsList.Add(newPartition);
                }
                words.RemoveAt(index);
                words.InsertRange(index, partitionsList);
            }




            commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }
        Console.WriteLine(string.Join(" ", words));
    }

    static void FixInvalidIndexes(List<string> words , ref int startIndex, ref int endIndex)
    {

        if (startIndex < 0)
        {
            startIndex = 0;
        }

        if (startIndex >= words.Count)
        {
            startIndex = words.Count - 1;
        }

        if (endIndex <= 0)
        {
            endIndex = 0;
        }

        if (endIndex >= words.Count)
        {
            endIndex = words.Count - 1;
        }
    }
    static void MergeWords(List<string> words, int startIndex, int endIndex)
    {
        var mergedText = string.Empty;

        for (int i = startIndex; i <= endIndex; i++)
        {
            var currentWord = words[startIndex];
            mergedText += currentWord;
            words.RemoveAt(startIndex);
        }

        words.Insert(startIndex, mergedText);
    }
}