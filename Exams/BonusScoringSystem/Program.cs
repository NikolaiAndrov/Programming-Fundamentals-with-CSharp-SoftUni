namespace BonusScoringSystem
{
    using System;
    internal class Program
    {
        static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());
            int maxAttendance = int.MinValue;
            bool flag = false;

            if (studentsCount == 0 && lecturesCount == 0 && addBonus == 0)
            {
                flag = true; 
            }

            for (int i = 0; i < studentsCount; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                if (attendance > maxAttendance)
                {
                    maxAttendance = attendance;
                }
            }

            double totalBonus = Math.Ceiling((double)maxAttendance / lecturesCount * (5 + addBonus));
            if (flag)
            {
                Console.WriteLine($"Max Bonus: {0}.");
                Console.WriteLine($"The student has attended {0} lectures.");
            }
            else
            {
                Console.WriteLine($"Max Bonus: {totalBonus}.");
                Console.WriteLine($"The student has attended {maxAttendance} lectures.");
            }
        }
    }
}