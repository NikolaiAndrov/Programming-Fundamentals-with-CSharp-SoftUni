using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var first = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();

        var second = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           .Select(char.Parse)
           .ToArray();

        var countFirst = 0;
        var countSecond = 0;

        var n = Math.Min(first.Length, second.Length);

        for (int i = 0; i < n; i++)
        {
            if (first[i] < second[i])
            {
                countFirst++;
            }
            else if (second[i] < first[i])
            {
                countSecond++;
            }
        }

        if (countFirst > countSecond)
        {
            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));
        }
        else if (countSecond > countFirst)
        {
            Console.WriteLine(string.Join("", second));
            Console.WriteLine(string.Join("", first));
        }
        else if (countFirst == countSecond)
        {
            if (first.Length < second.Length)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else if (second.Length < first.Length)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
            else
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
        }  
        
    }
}