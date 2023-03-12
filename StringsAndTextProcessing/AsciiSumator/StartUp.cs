public class StartUp
{
    public static void Main()
    {
        var startChar = char.Parse(Console.ReadLine());
        var endChar = char.Parse(Console.ReadLine());
        var text = Console.ReadLine();

        var sum = 0;

        for (int i = 0; i < text.Length; i++)
        {            
            var ch = text[i];
            if (text[i] > startChar && text[i] < endChar)
            {
                sum += text[i];
            }
        }

        Console.WriteLine(sum);
    }
}