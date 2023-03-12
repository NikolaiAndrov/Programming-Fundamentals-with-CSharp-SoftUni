byte n = byte.Parse(Console.ReadLine());
short sum = 0;

for (int i = 0; i < n; i++)
{
    short water = short.Parse(Console.ReadLine());
    short trySum = sum;
    trySum += water;

    if (trySum <= 255)
    {
        sum += water;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }
}

Console.WriteLine(sum);