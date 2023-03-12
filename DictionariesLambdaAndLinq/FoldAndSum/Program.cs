using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        var k = numbers.Length / 4;

        var leftRow = numbers.Take(k).Reverse().ToArray();

        var rightRow = numbers.Reverse().Take(k).ToArray();

        var finalLeftRow = leftRow.Concat(rightRow).ToArray();
        var finalRightRow = numbers.Skip(k).Take(2 * k).ToArray();

        var result = finalLeftRow.Zip(finalRightRow,((x, y) => x + y)).ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}