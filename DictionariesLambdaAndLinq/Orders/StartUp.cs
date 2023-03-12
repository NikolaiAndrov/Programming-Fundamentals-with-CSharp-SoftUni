public class StartUp
{
    public static void Main()
    {
        var products = new Dictionary<string, List<double>>();

        string product;

        while ((product = Console.ReadLine()) != "buy")
        {
            var productArgs = product.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var currentProduct = productArgs[0];
            var price = double.Parse(productArgs[1]);
            var quantity = double.Parse(productArgs[2]);

            if (!products.ContainsKey(currentProduct))
            {
                products[currentProduct] = new List<double>();
                products[currentProduct].Add(0);
                products[currentProduct].Add(0);
            }

            products[currentProduct][0] = price;
            products[currentProduct][1] += quantity;

        }

        foreach (var item in products)
        {
            Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):F2}");
        }
    }
}