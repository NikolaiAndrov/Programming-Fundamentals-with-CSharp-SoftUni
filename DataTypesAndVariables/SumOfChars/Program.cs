int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = 0; i < n; i++)
{
    char chr = char.Parse(Console.ReadLine());
    sum += chr;
}

Console.WriteLine($"The sum equals: {sum}");