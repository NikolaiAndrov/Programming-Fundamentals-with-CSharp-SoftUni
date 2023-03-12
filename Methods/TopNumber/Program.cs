namespace TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopNumbers(n);
        }

        static void PrintTopNumbers(int n) 
        {

            for (int i = 1; i <= n; i++)
            {
                int topNum = i;
                int sum = 0;
                bool isOdd = false;

                while (topNum > 0)
                {
                    int currentNum = topNum % 10;
                    sum += currentNum;
                    topNum /= 10;

                    if (currentNum % 2 != 0)
                    {
                        isOdd = true;
                    }
                }

                if (sum % 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}