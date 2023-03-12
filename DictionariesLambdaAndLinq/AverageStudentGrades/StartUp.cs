public class StartUp
{
    public static void Main()
    {
        var students = new Dictionary<string, List<decimal>>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = args[0];
            var grade = decimal.Parse(args[1]);
                
            if (!students.ContainsKey(name))
            {
                students[name] = new List<decimal>();
            }

            students[name].Add(grade);
        }

        foreach (var student in students)
        {
            Console.Write($"{student.Key} -> ");

            foreach (var grade in student.Value)
            {
                Console.Write($"{grade:f2} ");
            }

            Console.Write($"(avg: {student.Value.Average():f2})");
            Console.WriteLine();
        }

    }
}