namespace RepeatString
{
    internal class Program
    {
        static void Main()
        {
            string stringToRepeat = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(stringToRepeat, count);
            Console.WriteLine(result);
        }

        static string RepeatString(string stringToRepeat, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += stringToRepeat;
            }

            return result;
        }
    }
}