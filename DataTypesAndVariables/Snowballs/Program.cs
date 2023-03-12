using System.Numerics;

byte n = byte.Parse(Console.ReadLine());
BigInteger snowballMax = 0;
BigInteger maxSnow = 0;
BigInteger maxTime = 0;
BigInteger maxQuality = 0;

for (int i = 0; i < n; i++)
{
    short snowballSnow = short.Parse(Console.ReadLine());
    short snowballTime = short.Parse(Console.ReadLine());
    short snowballQuality = short.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow((snowballSnow / (BigInteger)snowballTime), snowballQuality);

    if (snowballValue > snowballMax)
    {
        snowballMax = snowballValue;
        maxSnow = snowballSnow;
        maxTime = snowballTime;
        maxQuality = snowballQuality;
    }
}

Console.WriteLine($"{maxSnow} : {maxTime} = {snowballMax} ({maxQuality})");