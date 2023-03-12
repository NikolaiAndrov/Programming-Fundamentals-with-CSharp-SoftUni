namespace SoftUniReception
{
    using System;
    internal class Program
    {
        static void Main()
        {
            int employeeEfficiency1 = int.Parse(Console.ReadLine());
            int employeeEfficiency2 = int.Parse(Console.ReadLine());
            int employeeEfficiency3 = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = employeeEfficiency1 + employeeEfficiency2 + employeeEfficiency3;
            int hours = 0;
            while (students > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }

                students -= studentsPerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}