﻿using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"\b(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();
        MatchCollection matches = regex.Matches(input);

        foreach (Match match in matches)
        {
            string day = match.Groups["day"].Value;
            string month = match.Groups["month"].Value;
            string year = match.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }

    }
}