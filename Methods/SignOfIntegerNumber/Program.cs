using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
       PrintSign(num);
    }




    public static void PrintSign(int num)
    {
        if (num > 0)
        {
            Console.WriteLine($"The number {num} is positive.");
        }
        else if (num == 0)
        {
            Console.WriteLine($"The number {num} is zero.");
        }
        else
        {
            Console.WriteLine($"The number {num} is negative.");
        }
    }

}