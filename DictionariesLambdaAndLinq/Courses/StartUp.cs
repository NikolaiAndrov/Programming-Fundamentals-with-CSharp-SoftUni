public class StartUp
{
    public static void Main()
    {
        var courses = new Dictionary<string, List<string>>();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var args = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            var courseName = args[0];
            var student = args[1];

            if (!courses.ContainsKey(courseName))
            {
                courses[courseName] = new List<string>();
            }

            courses[courseName].Add(student);
        }

        foreach (var course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", course.Value)}");
        }
    }
}