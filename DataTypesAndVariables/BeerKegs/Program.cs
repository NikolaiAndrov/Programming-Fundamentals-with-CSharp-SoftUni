byte n = byte.Parse(Console.ReadLine());
decimal max = 0m;
string maxModel = string.Empty;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    uint height = uint.Parse(Console.ReadLine());

    decimal sqare = (decimal)Math.PI * (decimal)Math.Pow(radius, 2) * height;

    if (sqare > max)
    {
        max = sqare;
        maxModel = model;
    }
}

Console.WriteLine(maxModel);