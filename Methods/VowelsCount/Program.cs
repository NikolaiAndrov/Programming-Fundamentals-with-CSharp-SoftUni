namespace VowelsCount
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int lowerCount = GetVowelsCount(input);
            Console.WriteLine(lowerCount);
        }

        static int GetVowelsCount(string input)
        {
            char[] vowels =  {'a', 'o', 'u', 'e', 'i'};
            int counter = 0;

            foreach (var item in input)
            {
                if (vowels.Contains(char.ToLower(item)))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}