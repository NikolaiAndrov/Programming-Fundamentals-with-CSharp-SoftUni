namespace Calculations
{
    internal class Program
    {
        static void Main()
        {
            string commaand = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            CalculateNumbers(commaand, n1, n2);
        }

        static void CalculateNumbers(string commaand, int n1, int n2)
        {
            if (commaand == "add")
            {
                Console.WriteLine(n1 + n2);
            }
            else if (commaand == "multiply")
            {
                Console.WriteLine(n1 * n2);
            }
            else if (commaand == "subtract")
            {
                Console.WriteLine(n1 - n2);
            }
            else if (commaand == "divide")
            {
                Console.WriteLine(n1 / n2);
            }
        }
    }
}