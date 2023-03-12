namespace Orders
{
    internal class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = CalculateOrder(product, quantity);
            Console.WriteLine($"{totalPrice:F2}");
        }

        static double CalculateOrder(string product, int quantity) 
        {
            double price = 0.0;

            if (product == "coffee")
            {
                price = 1.50;
            }
            else if (product == "water")
            {
                price = 1.00;
            }
            else if (product == "coke")
            {
                price = 1.40;
            }
            else if (product == "snacks")
            {
                price = 2.00;
            }

            double totalPrice = price * quantity;
            return totalPrice;
        }
    }
}