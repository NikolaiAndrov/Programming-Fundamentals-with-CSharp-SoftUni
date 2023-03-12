int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= n; i++)
{
    int oddNum = i * 2 - 1;
    sum += oddNum;
    Console.WriteLine(oddNum);
}

Console.WriteLine($"Sum: {sum}");