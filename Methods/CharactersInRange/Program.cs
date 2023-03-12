namespace CharactersInRange
{
    internal class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            List<char> charRange = new List<char>();
            GetCharRange(a, b, charRange);

            Console.WriteLine(string.Join(" ", charRange));
        }

        static void GetCharRange(char a, char b, List<char> charRange)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    charRange.Add((char)i);
                }
            }
            else
            {
                for (int i = a - 1; i > b; i--)
                {
                    charRange.Add((char)i);
                }

                charRange.Reverse();
            }
            
        }
    }
}