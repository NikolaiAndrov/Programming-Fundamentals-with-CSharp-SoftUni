using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"(\#|\|)(?<food>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();

        MatchCollection matches = regex.Matches(input);
        CalculateCalories(matches);
        PrintFoodInfo(matches);
    }

    static void PrintFoodInfo(MatchCollection matches)
    {
        foreach (Match match in matches)
        {
            Console.WriteLine($"Item: {match.Groups["food"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
        }
    }
    static void CalculateCalories(MatchCollection matches)
    {
        int calories = 0;

        foreach (Match match in matches)
        {
            calories += int.Parse(match.Groups["calories"].Value);
        }

        int days = calories / 2000;
        Console.WriteLine($"You have food to last you for: {days} days!");
    }
}