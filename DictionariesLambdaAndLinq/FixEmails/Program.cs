using System;
using System.Linq;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        
        while (name != "stop")
        {
            var email = Console.ReadLine().Split('.');

            if (email[1] != "us" && email[1] != "uk")
            {
                var currentEmail = string.Join(".", email);
                Console.WriteLine($"{name} -> {currentEmail}");
            }


            name = Console.ReadLine();
        }
    }
}