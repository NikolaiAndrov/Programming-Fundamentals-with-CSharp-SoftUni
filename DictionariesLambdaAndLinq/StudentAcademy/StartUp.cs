public class StartUp
{
    public static void Main()
    {
        var students = new Dictionary<string, List<double>>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var student = Console.ReadLine();
            var grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(student))
            {
                students[student] = new List<double>();
            }

            students[student].Add(grade);
        }

        foreach (var student in students)
        {
            if (student.Value.Average() >= 4.50)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
            }
        }
    }
}