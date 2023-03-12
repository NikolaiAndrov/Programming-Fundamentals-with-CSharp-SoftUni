using System;
using System.Collections.Generic;
using System.Linq;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday",
            "Friday", "Saturday", "Sunday"};

            int n = int.Parse(Console.ReadLine());

            if (n > 0 && n <= 7)
            {
                Console.WriteLine(dayOfWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
