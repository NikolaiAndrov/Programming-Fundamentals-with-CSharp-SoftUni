using System;
using System.Linq;
using System.Collections.Generic;
public class StartUp
{
    public static void Main()
    {
        var countries = new Dictionary<string, long>();
        var countriesAndCities = new Dictionary<string, Dictionary<string, int>>();
        AddPopulation(countries, countriesAndCities);
        PrintCountriesCitiesAndPopulation(countries, countriesAndCities);
    }

    static void PrintCountriesCitiesAndPopulation(Dictionary<string, long> countries, Dictionary<string, Dictionary<string, int>> countriesAndCities)
    {
        foreach (var country in countries.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($"{country.Key} (total population: {country.Value})");
            PrintCities(country.Key, countriesAndCities);
        }
    }
    static void PrintCities(string countryNeeded, Dictionary<string, Dictionary<string, int>> countriesAndCities)
    {
        foreach (var country in countriesAndCities)
        {
            if (countryNeeded == country.Key)
            {
                foreach(var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
    static void AddPopulation(Dictionary<string, long> countries, Dictionary<string, Dictionary<string, int>> countriesAndCities)
    {
        string input;

        while ((input = Console.ReadLine()) != "report")
        {
            var populationInfo = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
            var city = populationInfo[0];
            var country = populationInfo[1];
            var population = int.Parse(populationInfo[2]);

            if (!countries.ContainsKey(country))
            {
                countries[country] = 0;
            }
            countries[country] += population;

            if (!countriesAndCities.ContainsKey(country))
            {
                countriesAndCities[country] = new Dictionary<string, int>();
                
            }

            if (!countriesAndCities[country].ContainsKey(city))
            {
                countriesAndCities[country][city] = 0;
            }
            countriesAndCities[country][city] = population;
        }
    }
}