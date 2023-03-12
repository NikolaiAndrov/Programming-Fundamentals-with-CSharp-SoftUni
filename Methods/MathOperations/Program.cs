namespace MathOperations
{
    internal class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());
            int result = MathOperations(n1, sign, n2);
            Console.WriteLine(result);
        }

        static int MathOperations(int n1, string sign, int n2)
        {
            int result = 0;

            if (sign == "/")
            {
                result = n1 / n2;
            }
            else if (sign == "*")
            {
                result = n1 * n2;
            }
            else if (sign == "+")
            {
                result = n1 + n2;
            }
            else if (sign == "-")
            {
                result = n1 - n2;
            }

            return result;
        }
    }
}