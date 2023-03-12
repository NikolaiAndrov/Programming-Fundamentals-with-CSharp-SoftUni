namespace SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            CheckNumbers(n);
        }

        static void CheckNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero. ");
            }
            else
            {
                Console.WriteLine($"The number {n} is negative. ");
            }
        }
    }
}