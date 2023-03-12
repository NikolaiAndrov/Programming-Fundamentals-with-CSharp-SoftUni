namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (type == "int")
            {
                int a = int.Parse(first);
                int b = int.Parse(second);
                int grater = GraterValue(a, b);
                Console.WriteLine(grater);
            }
            else if (type == "char")
            {
                char a = char.Parse(first);
                char b = char.Parse(second);
                char grater = GraterValue(a, b);
                Console.WriteLine(grater);
            }
            else if (type == "string")
            {
                string grater = GraterValue(first, second);
                Console.WriteLine(grater);
                
            }
        }

        static string GraterValue(string a, string b)
        {
            int grater = a.CompareTo(b);

            if (grater == 1)
            {
                return a;
            }

            return b;
        }
        static char GraterValue(char a, char b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
        static int GraterValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }
    }
}