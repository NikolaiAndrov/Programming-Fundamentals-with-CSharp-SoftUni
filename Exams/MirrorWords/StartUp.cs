using System;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"(\@|\#)(?<words>[A-Za-z]{3,})\1{2}(?<words2>[A-Za-z]{3,})\1";
        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();
        MatchCollection matches = regex.Matches(input);

        List<string> mirrorWords = new List<string>();

        foreach (Match match in matches)
        {
            string reversedWord = GetReversedWord(match.Groups["words2"].Value);

            if (match.Groups["words"].Value == reversedWord)
            {
                string mirrorWord = $"{match.Groups["words"].Value} <=> {match.Groups["words2"].Value}";
                mirrorWords.Add(mirrorWord);
            }
        }

        if (matches.Count == 0)
        {
            Console.WriteLine("No word pairs found!");
        }
        else if (matches.Count > 0)
        {
            Console.WriteLine($"{matches.Count} word pairs found!");
        }

        if (mirrorWords.Count == 0)
        {
            Console.WriteLine("No mirror words!");
        }
        else if (mirrorWords.Count > 0)
        {
            Console.WriteLine("The mirror words are:");
            Console.WriteLine(string.Join(", ", mirrorWords));
        }
    }

    static string GetReversedWord(string word)
    {
        char[] chars = word.Reverse().ToArray();
        string reversedWord = new string(chars);
        return reversedWord;
    }
}