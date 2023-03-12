using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<quantity>\d+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$";
        Regex regex = new Regex(pattern);

        double totalPrice = 0;
        string input;

        while ((input = Console.ReadLine()) != "end of shift")
        {
            Match match = regex.Match(input);

            if (match.Success)
            {
                string name = match.Groups["name"].Value;
                string product = match.Groups["product"].Value;
                int quantity = int.Parse(match.Groups["quantity"].Value);
                double price = double.Parse(match.Groups["price"].Value);
                double currentTotalPrice = price * quantity;
                totalPrice += currentTotalPrice;

                Console.WriteLine($"{name}: {product} - {currentTotalPrice:F2}");
            }
        }

        Console.WriteLine($"Total income: {totalPrice:F2}");
    }
}