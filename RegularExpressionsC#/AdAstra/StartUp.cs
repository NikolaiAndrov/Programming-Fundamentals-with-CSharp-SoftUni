using System.Text.RegularExpressions;
public class StartUp
{
    public static void Main()
    {
        string pattern = @"(#|\|)(?<product>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";
        Regex regex = new Regex(pattern);
        string input = Console.ReadLine();
        MatchCollection matches = regex.Matches(input);

        int days = CalculateCalories(matches);
        Console.WriteLine($"You have food to last you for: {days} days!");
        PrintProducts(matches);
    }

    static void PrintProducts(MatchCollection matches)
    {
        foreach(Match match in matches)
        {
            if(match.Success)
            {
                Console.WriteLine($"Item: {match.Groups["product"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
            }
        }
    }
    static int CalculateCalories(MatchCollection matches)
    {
        int calories = 0;
        
        foreach (Match match in matches)
        {
            if (match.Success)
            {
                calories += int.Parse(match.Groups["calories"].Value);
            }
        }

        int days = calories / 2000;
        return days;
    }
}
