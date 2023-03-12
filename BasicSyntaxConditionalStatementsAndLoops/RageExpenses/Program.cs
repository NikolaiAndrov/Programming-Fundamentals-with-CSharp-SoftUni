int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice  = double.Parse(Console.ReadLine());
double keyboardPrice   = double.Parse(Console.ReadLine());
double displayPrice    = double.Parse(Console.ReadLine());

double headsetCount = 0;
double mouseCount = 0;
double keyboardCount = 0;
double displayCount = 0;

for (int i = 1; i <= lostGames; i++)
{
	if (i % 2 == 0)
	{
		headsetCount++;
	}
	if (i % 3 == 0)
	{
		mouseCount++;
	}
	if (i % 6 == 0)
	{
		keyboardCount++;
	}
	if (i % 12 == 0)
	{
		displayCount++;
	}
}

double totalPrice = (headsetPrice * headsetCount) + (mousePrice * mouseCount) + (keyboardPrice * keyboardCount) + (displayPrice * displayCount);

Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");