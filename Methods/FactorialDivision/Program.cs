namespace FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double f1 = Factorial(n1);
            double f2 = Factorial(n2);
            double result = f1 / f2;
            Console.WriteLine($"{result:F2}");

            
        }

        static double Factorial(double n)
        {
            double factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}