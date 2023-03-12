using System;
internal class Program
{
    private static void Main(string[] args)
    {
        PrintReceipt();
    }

    public static void PrintReceipt()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }
    public static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("------------------------------");
    }
    public static void PrintBody()
    {
        Console.WriteLine("Charged to____________________");
        Console.WriteLine("Received by___________________");
    }

    public static void PrintFooter()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("© SoftUni");
    }
}