namespace AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = AddAndSubtract(n1, n2, n3);
            Console.WriteLine(result);
        }

        static int AddAndSubtract(int n1, int n2, int n3)
        {
            int result = (n1 + n2) - n3;
            return result;
        }
    }
}