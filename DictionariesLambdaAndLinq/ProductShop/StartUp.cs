public class StartUp
{
    public static void Main()
    {
        var shops = new Dictionary<string, Dictionary<string, double>>();

        string input;

        while ((input = Console.ReadLine()) != "Revision")
        {
            var args = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var shop = args[0];
            var product = args[1];
            var price = double.Parse(args[2]);

            if (!shops.ContainsKey(shop))
            {
                shops[shop] = new Dictionary<string, double>();
            }

            if (!shops[shop].ContainsKey(product))
            {
                shops[shop][product] = 0;
            }

            shops[shop][product] = price;
        }

        foreach (var shop in shops.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{shop.Key}->");

            foreach (var product in shop.Value)
            {
                Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
            }
        }
    }
}