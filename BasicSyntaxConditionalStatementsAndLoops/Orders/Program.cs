using System.Diagnostics;
using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
double totalPrice = 0;

for (int i = 1; i <= n; i++)
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    double capsuleCount = double.Parse(Console.ReadLine());
    double sum = 0;
    sum = capsulePrice * capsuleCount * days;
    totalPrice += sum;
    Console.WriteLine($"The price for the coffee is: ${sum:F2}");
}

Console.WriteLine($"Total: ${totalPrice:F2}");