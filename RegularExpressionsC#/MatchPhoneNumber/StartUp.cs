using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"\+\b359(\s|-)2\1\d{3}\1\d{4}\b";
        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();

        MatchCollection matchCollection = regex.Matches(input);
        Console.WriteLine(string.Join(", ", matchCollection));
    }
}