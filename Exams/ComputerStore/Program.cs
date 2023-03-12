string command = Console.ReadLine();
double sum = 0;

while (command != "special")
{
	if (command == "regular")
	{
        break;
    }

    double num = double.Parse(command);

    if (num < 0)
    {
        Console.WriteLine("Invalid price!");
        command = Console.ReadLine();
        continue;
    }

    sum += num;

    command = Console.ReadLine();
}

double taxes = sum * 0.2;

if (sum == 0)
{
    Console.WriteLine("Invalid order!");
}
else if (command == "special")
{
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {sum:F2}$");
    Console.WriteLine($"Taxes: {taxes:F2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {((sum + taxes) * 0.9):F2}$");
}
else
{
    Console.WriteLine("Congratulations you've just bought a new computer!");
    Console.WriteLine($"Price without taxes: {sum:F2}$");
    Console.WriteLine($"Taxes: {taxes:F2}$");
    Console.WriteLine("-----------");
    Console.WriteLine($"Total price: {(sum + taxes):F2}$");
}
