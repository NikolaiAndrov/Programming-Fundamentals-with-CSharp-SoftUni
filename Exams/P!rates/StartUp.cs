using System;
using System.Collections.Generic;
using System.Linq;
public class StartUp
{
    public static void Main()
    {
        var citiesAndResources = new Dictionary<string, List<int>>();
        AddCitiesAndResources(citiesAndResources);

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var town = args[1];

            if (command == "Plunder")
            {
                var people = int.Parse(args[2]);
                var gold = int.Parse(args[3]);
                Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                Plunder(citiesAndResources, town, people, gold);
            }
            else if (command == "Prosper")
            {
                var gold = int.Parse(args[2]);

                if (gold < 0)
                {
                    Console.WriteLine("Gold added cannot be a negative number!");
                    continue;
                }

                if (citiesAndResources.ContainsKey(town))
                {
                    citiesAndResources[town][1] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {citiesAndResources[town][1]} gold.");
                }
            }
        }

        PrintCitiesAndResources(citiesAndResources);
    }

    static void PrintCitiesAndResources(Dictionary<string, List<int>> citiesAndResources)
    {
        if (citiesAndResources.Count > 0)
        {
            Console.WriteLine($"Ahoy, Captain! There are {citiesAndResources.Count} wealthy settlements to go to:");

            foreach (var item in citiesAndResources)
            {
                Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
            }
        }
        else
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }
    }
    static void Plunder(Dictionary<string, List<int>> citiesAndResources, string town, int people, int gold)
    {
        if (citiesAndResources.ContainsKey(town))
        {
            citiesAndResources[town][0] -= people;
            citiesAndResources[town][1] -= gold;

            if (citiesAndResources[town][0] <= 0 || citiesAndResources[town][1] <= 0)
            {
                citiesAndResources.Remove(town);
                Console.WriteLine($"{town} has been wiped off the map!");
            }
        }

    }
    static void AddCitiesAndResources(Dictionary<string, List<int>> citiesAndResources)
    {
        string input;

        while ((input = Console.ReadLine()) != "Sail")
        {
            var args = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
            var city = args[0];
            var population = int.Parse(args[1]);
            var gold = int.Parse(args[2]);

            if (!citiesAndResources.ContainsKey(city))
            {
                citiesAndResources[city] = new List<int>();
                citiesAndResources[city].Add(0);
                citiesAndResources[city].Add(0);
            }

            citiesAndResources[city][0] += population;
            citiesAndResources[city][1] += gold;
        }
    }
}