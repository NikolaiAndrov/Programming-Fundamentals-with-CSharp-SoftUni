using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
        string capitalLetters = GetCapitalLetters(input[0]);
        List<string> words = new List<string>();
        string[] text = input[2].Split(" ", StringSplitOptions.RemoveEmptyEntries);
        ExtractWords(input[1], text, capitalLetters, words);

        PrintWords(words);
    }

    static void PrintWords(List<string> words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
    static void ExtractWords(string input, string[] text, string capitalLetters, List<string> words)
    {
        string pattern = @"(?<ascii>\d{2})\:(?<length>\d{2})";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);

        foreach (var letter in capitalLetters)
        {
            bool isAdded = false;

            foreach (Match match in matches)
            {
                int asciiInt = int.Parse(match.Groups["ascii"].Value);
                char ascii = (char)asciiInt;
                int length = int.Parse(match.Groups["length"].Value) + 1;

                if (ascii != letter)
                {
                    continue;
                }

                foreach (var word in text)
                {

                    if (word.Length == length && word[0] == ascii)
                    {
                        words.Add(word);
                        isAdded = true;
                        break;
                    }
                }

                if (isAdded)
                {
                    break;
                }
            }
        }
    }
    static string GetCapitalLetters(string input)
    {
        string pattern = @"(\#|\$|\%|\*|\&)(?<capitals>[A-Z]+)\1";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);
        return match.Groups["capitals"].Value;
    }
}