using System.Text;

public class StartUp
{
    public static void Main()
    {
        var bombText = Console.ReadLine();
        StringBuilder bombedText = new StringBuilder();
        var bombPower = 0;

        for (int i = 0; i < bombText.Length; i++)
        {
            var ch = bombText[i];

            if (ch == '>')
            {
                bombedText.Append(ch);
                var currentBombPower = int.Parse(char.ToString(bombText[i + 1]));
                bombPower += currentBombPower;
            }
            else
            {
                if (bombPower > 0)
                {
                    bombPower--;
                }
                else
                {
                    bombedText.Append(ch);
                }
            }
        }

        Console.WriteLine(bombedText);
    }
}