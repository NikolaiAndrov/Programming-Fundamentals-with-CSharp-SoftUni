using System.Numerics;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());

long sum = (long)num1 + num2;
long division = sum / num3;
BigInteger multiplication = (BigInteger)division * num4;

Console.WriteLine(multiplication);