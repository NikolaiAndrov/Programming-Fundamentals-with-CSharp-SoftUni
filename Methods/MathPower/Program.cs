using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(number, power));
    }
}