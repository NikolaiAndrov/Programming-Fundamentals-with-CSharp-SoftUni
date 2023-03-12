namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int result = MultiplyEvensByOdds(input);
            Console.WriteLine(result);
        }

        static int MultiplyEvensByOdds(string input)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsDigit(currentChar))
                {
                    int currentNum = int.Parse(currentChar.ToString());

                    if (currentNum % 2 == 0) 
                    {
                        evenSum += currentNum;
                    }
                    else
                    {
                        oddSum += currentNum;
                    }
                }  
            }

            int result = evenSum * oddSum;
            return result;
        }
    }
}