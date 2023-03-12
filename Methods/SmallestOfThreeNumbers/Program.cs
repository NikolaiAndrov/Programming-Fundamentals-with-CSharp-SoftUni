namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int smallestNum = GetSmallestNumber(n1, n2, n3);
            Console.WriteLine(smallestNum);
        }

        static int GetSmallestNumber(int n1, int n2, int n3)
        {

            int smallestNum = 0;

            if (n1 < n2 && n1 < n3)
            {
                smallestNum = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                smallestNum = n2;
            }
            else if (n3 < n1 && n3 < n2)
            {
                smallestNum = n3;
            }
            else
            {
                smallestNum = n3;
            }
            
            return smallestNum;
        }
    }
}