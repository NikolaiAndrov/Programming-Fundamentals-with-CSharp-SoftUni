using System;
using System.Linq;
using System.Collections.Generic;
public class StartUp
{
    public static void Main()
    {
        var cities = new Dictionary<string, List<int>>();
        AddCities(cities);
        GetCommands(cities);
        PrintCities(cities);
    }

    static void PrintCities(Dictionary<string, List<int>> cities)
    {
        if (cities.Count > 0)
        {
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

            foreach (var city in cities)
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
            }
        }
        else
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }
    }
    static void GetCommands(Dictionary<string, List<int>> cities)
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var args = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var city = args[1];

            if (command == "Plunder")
            {
                var people = int.Parse(args[2]);
                var gold = int.Parse(args[3]);

                cities[city][0] -= people;
                cities[city][1] -= gold;
                Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");

                if (cities[city][0] <= 0 || cities[city][1] <= 0)
                {
                    cities.Remove(city);
                    Console.WriteLine($"{city} has been wiped off the map!");
                }
            }
            else if (command == "Prosper")
            {
                var gold = int.Parse(args[2]);

                if (gold < 0)
                {
                    Console.WriteLine($"Gold added cannot be a negative number!");
                    continue;
                }

                cities[city][1] += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city][1]} gold.");
            }
        }
    }
    static void AddCities(Dictionary<string, List<int>> cities)
    {
        string input;

        while ((input = Console.ReadLine()) != "Sail")
        {
            var args = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
            var city = args[0];
            var population = int.Parse(args[1]);
            var gold = int.Parse(args[2]);

            if (!cities.ContainsKey(city))
            {
                cities[city] = new List<int>();
                cities[city].Add(0);
                cities[city].Add(0);
            }

            cities[city][0] += population;
            cities[city][1] += gold;
        }
    }
}
