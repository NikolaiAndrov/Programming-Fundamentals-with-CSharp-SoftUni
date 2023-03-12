public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var personalInfo = Console.ReadLine();
            var nameStartIndex = personalInfo.IndexOf('@');
            var nameEndIndex = personalInfo.IndexOf('|');
            var name = personalInfo.Substring(nameStartIndex + 1,nameEndIndex - nameStartIndex - 1);
            
            var ageStartIndex = personalInfo.IndexOf('#');
            var ageEndIndex = personalInfo.IndexOf('*');
            var age = personalInfo.Substring(ageStartIndex + 1, ageEndIndex - ageStartIndex - 1);

            Console.WriteLine($"{name} is {age} years old.");
        }
    }
}