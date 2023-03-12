using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var courseSchedule = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string input;

        while ((input = Console.ReadLine()) != "course start")
        {
            var args = input.Split(":");
            var command = args[0];

            if (command == "Add")
            {
                var lesson = args[1];

                if (!courseSchedule.Contains(lesson))
                {
                    courseSchedule.Add(lesson);
                }
            }
            else if (command == "Insert")
            {
                var lesson = args[1];
                var index = int.Parse(args[2]);

                if (!courseSchedule.Contains(lesson))
                {
                    courseSchedule.Insert(index, lesson);
                }
            }
            else if (command == "Remove")
            {
                var lesson = args[1];
                RemoveLesson(courseSchedule, lesson);
            }
            else if (command == "Swap")
            {
                var lesson1 = args[1];
                var lesson2 = args[2];
                SwapElements(courseSchedule, lesson1, lesson2);
            }
            else if (command == "Exercise")
            {
                var lesson = args[1];
                AddExercise(courseSchedule, lesson);
            }
        }

        for (int i = 0; i < courseSchedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{courseSchedule[i]}");
        }
    }

    static void AddExercise(List<string> courseSchedule, string lesson)
    {
        var exercise = lesson + "-" + "Exercise";

        if (courseSchedule.Contains(lesson) && !courseSchedule.Contains(exercise))
        {
            var index = courseSchedule.IndexOf(lesson) + 1;
            courseSchedule.Insert(index, exercise);
        }
        else if (!courseSchedule.Contains(lesson))
        {
            courseSchedule.Add(lesson);
            courseSchedule.Add(exercise);
        }
    }

    static void SwapElements(List<string> courseSchedule, string lesson1, string lesson2)
    {
       
        if (courseSchedule.Contains(lesson1) && courseSchedule.Contains(lesson2))
        {
            var lesson1Index = courseSchedule.IndexOf(lesson1);
            var lesson2Index = courseSchedule.IndexOf(lesson2);
            courseSchedule[lesson1Index] = lesson2;
            courseSchedule[lesson2Index] = lesson1;

            var exercise1 = lesson1 + "-" + "Exercise";
            var exercise2 = lesson2 + "-" + "Exercise";

            if (courseSchedule.Contains(exercise1))
            {
                courseSchedule.Remove(exercise1);
                courseSchedule.Insert(lesson2Index + 1, exercise1);
            }

            if (courseSchedule.Contains(exercise2))
            {
                courseSchedule.Remove(exercise2);
                courseSchedule.Insert(lesson1Index + 1, exercise2);
            }
        }
    }
    
    static void RemoveLesson(List<string> courseSchedule, string lesson)
    {
        var exercise = lesson + "-" + "Exercise";

        if (courseSchedule.Contains(lesson))
        {
            courseSchedule.Remove(lesson);
        }

        if (courseSchedule.Contains(exercise))
        {
            courseSchedule.Remove(exercise);
        }
    }
}
