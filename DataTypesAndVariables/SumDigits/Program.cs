int num = int.Parse(Console.ReadLine());
int sum = 0;
int number = num;

while (number > 0)
{
    int lastDigit = number % 10;
    number /= 10;
    sum += lastDigit;
}

Console.WriteLine(sum);
