using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string text = Console.ReadLine();

        Dictionary<string, long> emojis = new Dictionary<string, long>();

        long threshold = GetCoolThreshold(text);

        GetEmojisAndValues(text, emojis);

        PrintEmojis(emojis, threshold);
    }

    static void PrintEmojis(Dictionary<string, long> emojis, long threshold)
    {
        Console.WriteLine($"Cool threshold: {threshold}");
        Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

        foreach (var emoji in emojis.Where(x => x.Value >= threshold))
        {
            Console.WriteLine(emoji.Key);
        }
    }
    static void GetEmojisAndValues(string text, Dictionary<string, long> emojis)
    {
        string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);

        foreach (Match match in matches)
        {
            if (match.Success)
            {
                long value = GetEmojiValue(match.Groups["emoji"].Value);

                if (!emojis.ContainsKey(match.Value))
                {
                    emojis[match.Value] = value;
                }
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
    static long GetCoolThreshold(string text)
    {
        string pattern = @"\d";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        long threshold = 1;

        foreach (Match match in matches)
        {
            threshold *= int.Parse(match.Value);
        }

        return threshold;
    }
}