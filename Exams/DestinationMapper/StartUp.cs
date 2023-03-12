using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1";
        Regex regex = new Regex(pattern);

        string inputDestinations = Console.ReadLine();

        MatchCollection matches = regex.Matches(inputDestinations);
        List<string> destinations = new List<string>();

        int points = 0;

        foreach (Match match in matches)
        {
            points += match.Groups["destination"].Length;
            destinations.Add(match.Groups["destination"].Value);
        }

        Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
        Console.WriteLine($"Travel Points: {points}");
    }
}