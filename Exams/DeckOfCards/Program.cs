using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var cards = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries) 
            .ToList();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];

            if (command == "Add")
            {
                var card = args[1];

                if (cards.Contains(card))
                {
                    Console.WriteLine("Card is already in the deck");
                    continue;
                }

                cards.Add(card);
                Console.WriteLine("Card successfully added");
            }
            else if (command == "Remove")
            {
                var card = args[1];

                if (!cards.Contains(card))
                {
                    Console.WriteLine("Card not found");
                    continue;
                }

                cards.Remove(card);
                Console.WriteLine("Card successfully removed");
            }
            else if (command == "Remove At")
            {
                var index = int.Parse(args[1]);

                if (index < 0 || index >= cards.Count)
                {
                    Console.WriteLine("Index out of range");
                    continue;
                }

                cards.RemoveAt(index);
                Console.WriteLine("Card successfully removed");
            }
            else if (command == "Insert")
            {
                var index = int.Parse(args[1]);
                var card = args[2];

                if (index < 0 || index >= cards.Count)
                {
                    Console.WriteLine("Index out of range");
                    continue;
                }

                if (cards.Contains(card))
                {
                    Console.WriteLine("Card is already added");
                    continue;
                }

                cards.Insert(index, card);
                Console.WriteLine("Card successfully added");
            }
        }

        Console.WriteLine(string.Join(", ", cards));
    }
}