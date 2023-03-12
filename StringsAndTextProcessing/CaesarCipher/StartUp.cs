using System.Text;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();

        StringBuilder caesarCipher = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            var ch = (char)(input[i] + 3);
            caesarCipher.Append(ch);
        }

        Console.WriteLine(caesarCipher);
    }
}