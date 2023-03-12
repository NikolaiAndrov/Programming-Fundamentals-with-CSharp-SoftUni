while (true)
{
    int n = int.Parse(Console.ReadLine());
	n = Math.Abs(n);
	if (n % 2 == 0)
	{
        Console.WriteLine($"The number is: {n}");
        break;
	}
	Console.WriteLine("Please write an even number.");
}

