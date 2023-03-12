using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var pirateShip = Console.ReadLine()
            .Split(">")
            .Select(int.Parse)
            .ToList();

        var warship = Console.ReadLine()
            .Split(">")
            .Select(int.Parse)
            .ToList();

        var maximumHealth = int.Parse(Console.ReadLine());

        var input = Console.ReadLine();

        while (input != "Retire")
        {
            var args = input.Split();
            var command = args[0];

            if (command == "Fire")
            {
                var index = int.Parse(args[1]);
                var damage = int.Parse(args[2]);

                if (index >= 0 && index < warship.Count)
                {
                    warship[index] -= damage;

                    if (warship[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        return;
                    }
                }
            }
            else if (command == "Defend")
            {
                var startIndex = int.Parse(args[1]);
                var endIndex = int.Parse(args[2]);
                var damage = int.Parse(args[3]);

                if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        pirateShip[i] -= damage;

                        if (pirateShip[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;         
                        }
                    }
                }
            }
            else if (command == "Repair")
            {
                var index = int.Parse(args[1]);
                var health = int.Parse(args[2]);

                if (index >= 0 && index < pirateShip.Count)
                {
                    pirateShip[index] += health;

                    if (pirateShip[index] > maximumHealth)
                    {
                        pirateShip[index] = maximumHealth;
                    }
                }
            }
            else if (command == "Status")
            {
                var counter = 0;
                var min = maximumHealth * 0.2;

                for (int i = 0; i < pirateShip.Count; i++)
                {
                    if (pirateShip[i] < min)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"{counter} sections need repair.");
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
        Console.WriteLine($"Warship status: {warship.Sum()}");
    }
}