using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var sequence = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var indexes = Console.ReadLine();
        var moves = 0;
        bool isWinner = false;

        while (indexes != "end")
        {
            moves++;
            var args = indexes.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var index1 = int.Parse(args[0]);
            var index2 = int.Parse(args[1]);
            var additionalElement = "-";

            if (index1 < 0 || index2 < 0 || index1 >= sequence.Count || index2 >= sequence.Count || index1 == index2)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                additionalElement += moves + "a";
                sequence.Insert(sequence.Count / 2, additionalElement);
                sequence.Insert(sequence.Count / 2, additionalElement);
                indexes = Console.ReadLine();
                continue;
            }

            if (sequence[index1] == sequence[index2])
            {
                var element = sequence[index1];
                Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                sequence.RemoveAll(x => x == element);
            }
            else if (sequence[index1] != sequence[index2])
            {
                Console.WriteLine("Try again!");
                indexes = Console.ReadLine();
                continue;
            }

            var noRepeatingSequence = new HashSet<string>();

            for (int i = 0; i < sequence.Count; i++)
            {
                noRepeatingSequence.Add(sequence[i]);
            }

            if (sequence.Count == noRepeatingSequence.Count)
            {
                isWinner = true;
                break;
            }

            indexes = Console.ReadLine();
        }

        if (isWinner)
        {
            Console.WriteLine($"You have won in {moves} turns!");
        }
        else
        {
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}