internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double square = GetSquare(n);
        Console.WriteLine(square);
    }

    static double GetSquare(double num)
    {
        double result = num * num;
        return result;
    }
}