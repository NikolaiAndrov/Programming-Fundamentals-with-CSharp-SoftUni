using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";
        Regex regex = new Regex(pattern);

        string input = Console.ReadLine();
        MatchCollection emails = regex.Matches(input);

        foreach (Match email in emails)
        {
            Console.WriteLine(email.Value);
        }
    }
}