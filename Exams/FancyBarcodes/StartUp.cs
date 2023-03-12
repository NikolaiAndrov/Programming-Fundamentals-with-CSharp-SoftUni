using System.Text;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"\@\#+(?<product>[A-Z][A-Za-z|\d]{4,}[A-Z])\@\#+";
        Regex regex = new Regex(pattern);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string barcode = Console.ReadLine();
            Match match = regex.Match(barcode);
            
            if (match.Success)
            {
                string group = GetProductGroup(match.Groups["product"].Value);
                Console.WriteLine($"Product group: {group}");
            }
            else
            {
                Console.WriteLine("Invalid barcode");
            }
        }
    }

    static string GetProductGroup(string product)
    {
        StringBuilder group = new StringBuilder();

        foreach (var item in product)
        {
            if (char.IsDigit(item))
            {
                group.Append(item);
            }
        }

        if (group.Length == 0)
        {
            group.Append("00");
        }

        return group.ToString();
    }
}