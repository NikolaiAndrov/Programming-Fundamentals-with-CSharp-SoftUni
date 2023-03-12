using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @">>(?<type>[A-Za-z]+)<<(?<price>\d+\.?(\d+)?)!(?<quantity>\d+)";
        Regex regex = new Regex(pattern);

        List<string> furniture = new List<string>();
        double totalPrice = 0;

        string inputInfo;

        while ((inputInfo = Console.ReadLine()) != "Purchase")
        {
            Match match = regex.Match(inputInfo);
            if (match.Success)
            {
                string type = match.Groups["type"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                furniture.Add(type);
                totalPrice += price * quantity;
            }
        }

        Console.WriteLine("Bought furniture:");
        foreach (var item in furniture)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Total money spend: {totalPrice:F2}");
    }
}