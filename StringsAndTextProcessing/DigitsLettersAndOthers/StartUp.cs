using System.Text;

public class StartUp
{
    public static void Main()
    {
        var text = Console.ReadLine();

        StringBuilder digits = new StringBuilder();
        StringBuilder letters = new StringBuilder();
        StringBuilder symbols = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            var ch = text[i];

            if (char.IsDigit(ch))
            {
                digits.Append(ch);
            }
            else if (char.IsLetter(ch))
            {
                letters.Append(ch);
            }
            else
            {
                symbols.Append(ch);
            }
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(symbols);
    }
}