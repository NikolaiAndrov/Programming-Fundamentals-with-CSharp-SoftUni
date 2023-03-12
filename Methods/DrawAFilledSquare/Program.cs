using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        PrintFilledSquare(n);
    }
    public static void PrintFilledSquare(int n)
    {
        PrintHeaderRow(n);
        PrintMiddleRow(n);
        PrintFooterRow(n);
    }
    public static void PrintHeaderRow(int n)
    {
        Console.WriteLine(new string('-', n * 2));
    }
    public static void PrintMiddleRow(int n)
    {
        string elements = "-";
        for (int i = 1; i < n; i++)
        {
            elements += @"\/";
        }
        elements += "-";

        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine(elements);
        }
    }
    public static void PrintFooterRow(int n)
    {
        Console.WriteLine(new string('-', n * 2));
    }
}