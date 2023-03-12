using System.Text;
using System.Text.RegularExpressions;
public class StartUp
{
    public static void Main()
    {
        string name = "Niko";
        string capitals = "ABVN";

        if (capitals.Contains(name[0]))
        {
            Console.WriteLine(name[0]);
        }
    }
}