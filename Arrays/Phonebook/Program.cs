using System;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        var phoneNumbers = Console.ReadLine().Split(' ');
        var names = Console.ReadLine().Split(' ');
        string name = Console.ReadLine();
        bool isFound = false;

        while (name != "done")
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    if (name == names[j])
                    {
                        Console.WriteLine($"{name} -> {phoneNumbers[j]}");
                        isFound = true;
                        break;
                    }

                }
                if (isFound)
                {
                    break;
                }
            }


            name = Console.ReadLine();
        }
    }
}