using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();
        long threshold = GetThreshold(input);
        MatchCollection matches = regex.Matches(input);

        Console.WriteLine($"Cool threshold: {threshold}");
        Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");

        foreach(Match match in matches)
        {
            long value = GetEmojiValue(match.Groups["emoji"].Value);

            if(value >= threshold)
            {
                Console.WriteLine(match.Value);
            }
        }
    }

    static long GetEmojiValue(string emoji)
    {
        long value = 0;

        for (int i = 0; i < emoji.Length; i++)
        {
            value += emoji[i];
        }

        return value;
    }
    static long GetThreshold(string input)
    {
        string pattern = @"\d";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        long threshold = 1;

        foreach (Match match in matches)
        {
            if (match.Success)
            {
                threshold *= int.Parse(match.Value);
            }
        }

        return threshold;
    }
}
