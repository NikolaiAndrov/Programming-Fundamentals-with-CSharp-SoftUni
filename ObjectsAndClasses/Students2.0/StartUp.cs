public class StartUp
{
    public static void Main()
    {
        var students = new List<Student>();

        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            var studentInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var firstName = studentInfo[0];
            var lastName = studentInfo[1];
            var age = int.Parse(studentInfo[2]);
            var town = studentInfo[3];

            Student student = new Student(firstName, lastName, age, town);

            var containsStudent = false;

            foreach (var currentStudent in students)
            {
                if (currentStudent.FirstName == student.FirstName && currentStudent.LastName == student.LastName)
                {
                    currentStudent.Age = student.Age;
                    currentStudent.Town = student.Town;
                    containsStudent = true;
                }
            }

            if (!containsStudent)
            {
                students.Add(student);
            }
        }

        var searchedTown = Console.ReadLine();

        foreach (var student in students)
        {
            if (searchedTown == student.Town)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}

public class Student
{
    public Student(string firstName, string lastName, int age, string town)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Town = town;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }
}