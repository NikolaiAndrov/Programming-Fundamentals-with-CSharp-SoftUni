public class StartUp
{
    public static void Main()
    {
        string word;

        while ((word = Console.ReadLine()) != "end")
        {
            var temp = word.ToArray().Reverse().ToArray();
            var result = new string(temp);
            Console.WriteLine($"{word} = {result}");
        }
    }
}