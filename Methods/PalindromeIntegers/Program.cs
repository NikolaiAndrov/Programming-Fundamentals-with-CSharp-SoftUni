namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();

            while (n != "END")
            {
                if (IsPalindrom(n))
                {
                    Console.WriteLine("true");
                }
                else if (!IsPalindrom(n))
                {
                    Console.WriteLine("false");
                }

                n = Console.ReadLine();
            }
            
        }

        static bool IsPalindrom(string n)
        {
            string result = string.Empty;
            bool isPalindrom = false;

            for (int i = n.Length - 1; i >= 0; i--)
            {
                result += n[i];
            }

            if (n == result)
            {
                isPalindrom = true;
            }

            return isPalindrom;
        }
    }
}