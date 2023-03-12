using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main()
    {
        var rooms = Console.ReadLine()
            .Split("|", StringSplitOptions.RemoveEmptyEntries);

        var initialHealth = 100;
        var initialBitcoins = 0;
        var bestRoom = 0;

        foreach (var room in rooms)
        {
            var args = room.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            bestRoom++;

            if (command == "potion")
            {
                var currentHealth = int.Parse(args[1]);
                var needed = 100 - initialHealth;

                if (currentHealth <= needed)
                {
                    initialHealth += currentHealth;
                    Console.WriteLine($"You healed for {currentHealth} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
                else
                {
                    initialHealth += needed;
                    Console.WriteLine($"You healed for {needed} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                }
            }
            else if (command == "chest")
            {
                var bitcoins = int.Parse(args[1]);
                initialBitcoins += bitcoins;
                Console.WriteLine($"You found {bitcoins} bitcoins.");
            }
            else
            {
                var beast = args[0];
                var attack = int.Parse(args[1]);
                initialHealth -= attack;

                if (initialHealth > 0)
                {
                    Console.WriteLine($"You slayed {beast}.");
                }
                else
                {
                    Console.WriteLine($"You died! Killed by {beast}.");
                    Console.WriteLine($"Best room: {bestRoom}");
                    return;
                }
            }
        }

        Console.WriteLine("You've made it!");
        Console.WriteLine($"Bitcoins: {initialBitcoins}");
        Console.WriteLine($"Health: {initialHealth}");
    }
}