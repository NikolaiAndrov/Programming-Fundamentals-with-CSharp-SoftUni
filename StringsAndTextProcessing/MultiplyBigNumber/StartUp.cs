using System.Numerics;

public class StartUp
{
    public static void Main()
    {
        var n = BigInteger.Parse(Console.ReadLine());
        var m = int.Parse(Console.ReadLine());

        var result = n * m;
        Console.WriteLine(result);
        
    }
}