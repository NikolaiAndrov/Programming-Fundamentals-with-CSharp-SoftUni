namespace MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);
            }
        }
    }
}