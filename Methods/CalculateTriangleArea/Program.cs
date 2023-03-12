using System;
internal class Program
{
    private static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double heigh = double.Parse(Console.ReadLine());
        Console.WriteLine(TriangleArea(width, heigh)); 
    }

    public static double TriangleArea(double width, double heigh)
    {
        double area = (width * heigh) / 2;
        return area;
    }
}