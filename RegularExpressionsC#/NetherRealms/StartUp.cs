using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        var demonNames = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var demons = new SortedDictionary<string, List<double>>();
        GetDemonHealth(demonNames, demons);
        GetDemonDamage(demonNames, demons);
        PrintDemons(demons);
    }

    static void PrintDemons(SortedDictionary<string, List<double>> demons)
    {
        foreach (var demon in demons)
        {
            Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:F2} damage");
        }
    }
    static void GetDemonDamage(string[] demonNames, SortedDictionary<string, List<double>> demons)
    {
        string pattern = @"(?<nn>\-\d+(\.\d+)?)|(?<pnp>\+\d+(\.\d+)?)|(?<pn>\d+(\.\d+)?)";
        Regex regex = new Regex(pattern);

        foreach (var demon in demonNames)
        {
            MatchCollection matches = regex.Matches(demon);
            double damage = 0;

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    double num = double.Parse(match.Value);
                    damage += num;
                }
            }

            int multyplyCount = demon.Count(x => x == '*');
            int divideCount = demon.Count(x => x == '/');

            for (int i = 0; i < multyplyCount; i++)
            {
                damage *= 2;
            }

            for (int i = 0; i < divideCount; i++)
            {
                damage /= 2;
            }

            demons[demon][1] = damage;
        }
    }
    static void GetDemonHealth(string[] demonNames, SortedDictionary<string, List<double>> demons)
    {
        foreach (var demon in demonNames)
        {
            double health = 0;

            for (int i = 0; i < demon.Length; i++)
            {
                char ch = demon[i];

                if (!char.IsDigit(ch) &&
                    ch != '*' &&
                    ch != '/' &&
                    ch != '+' &&
                    ch != '-' &&
                    ch != '.')
                {
                    health += ch;
                }
            }

            if (!demons.ContainsKey(demon))
            {
                demons[demon] = new List<double>();
                demons[demon].Add(health);
                demons[demon].Add(0);
            }
        }
    }
}