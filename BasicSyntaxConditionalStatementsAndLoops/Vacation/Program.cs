int people = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();

decimal sum = 0m;
decimal totalSum = 0m;

if (type == "Students")
{
	if (day == "Friday")
	{
        sum = 8.45m;
	}
	else if (day == "Saturday")
	{
        sum = 9.80m;
    }
	else if (day == "Sunday")
	{
        sum = 10.46m;
    }
}
else if (type == "Business")
{
    if (day == "Friday")
    {
        sum = 10.90m;
    }
    else if (day == "Saturday")
    {
        sum = 15.60m;
    }
    else if (day == "Sunday")
    {
        sum = 16m;
    }

    if (people >= 100)
    {
        people -= 10;
    }
}
else if (type == "Regular")
{
    if (day == "Friday")
    {
        sum = 15m;
    }
    else if (day == "Saturday")
    {
        sum = 20m;
    }
    else if (day == "Sunday")
    {
        sum = 22.50m;
    }
}

totalSum = sum * people;

if (type == "Students")
{
    if (people >= 30)
    {
        totalSum *= 0.85m;
    }
}
else if (type == "Regular")
{
    if (people >= 10 && people <= 20)
    {
        totalSum *= 0.95m;
    }
}

Console.WriteLine($"Total price: {totalSum:F2}");