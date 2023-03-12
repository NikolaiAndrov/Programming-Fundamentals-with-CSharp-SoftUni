using System.Text;
public class StartUp
{
    public static void Main()
    {
        var key = Console.ReadLine();
        var text = Console.ReadLine();

        while (text.Contains(key))
        {
            var index = text.IndexOf(key);
            text = text.Remove(index, key.Length);
        }

        Console.WriteLine(text);
    }
}