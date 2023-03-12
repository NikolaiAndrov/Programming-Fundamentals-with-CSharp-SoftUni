using System.Text;
using System.Text.RegularExpressions;
public class StartUp
{
    public static void Main()
    {
        string pattern = @"(?<symbols>\D+)(?<digits>\d+)";
        Regex regex = new Regex(pattern);
        string input = Console.ReadLine().ToUpper();
        MatchCollection matches = regex.Matches(input);

        int symbolCount = GetUniqueSymbolsCount(matches);
        Console.WriteLine($"Unique symbols used: {symbolCount}");

        foreach (Match match in matches)
        {
            int n = int.Parse(match.Groups["digits"].Value);
            for (int i = 0; i < n; i++)
            {
                Console.Write(match.Groups["symbols"].Value);
            }
        }
    }

    static int GetUniqueSymbolsCount(MatchCollection matches)
    {
        var symbols = new HashSet<char>();

        foreach (Match match in matches)
        {
            int n = int.Parse(match.Groups["digits"].Value);

            if (n > 0)
            {
                string str = match.Groups["symbols"].Value;

                for (int i = 0; i < str.Length; i++)
                {
                    symbols.Add(str[i]);
                }
            }
        }

        return symbols.Count;
    }
}