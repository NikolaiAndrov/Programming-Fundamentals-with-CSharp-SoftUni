using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1\:\s\[(?<d1>\d+)\]\|\[(?<d2>\d+)\]\|\[(?<d3>\d+)\]\|$";
        Regex regex = new Regex(pattern);

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            Match match = regex.Match(input);

            if (match.Success)
            {
                var d1 = int.Parse(match.Groups["d1"].Value);
                var d2 = int.Parse(match.Groups["d2"].Value);
                var d3 = int.Parse(match.Groups["d3"].Value);
                var ch1 = (char)d1;
                var ch2 = (char)d2;
                var ch3 = (char)d3;

                Console.Write($"{match.Groups["tag"].Value}: ");
                Console.WriteLine($"{ch1}{ch2}{ch3}");

            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }
}