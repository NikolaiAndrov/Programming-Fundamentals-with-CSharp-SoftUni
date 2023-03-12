int n = int.Parse(Console.ReadLine());
int num = n;
int factorialSum = 0;

while (num > 0)
{
    int lastDigit = num % 10;
    num /= 10;

    int factorial = 1;

    for (int i = 1; i <= lastDigit; i++)
    {
        factorial *= i;
    }

    factorialSum += factorial;
}

if (factorialSum == n)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}