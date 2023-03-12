string username = Console.ReadLine();
string password = new string(username.Reverse().ToArray());

for (int i = 1; i <= 4; i++)
{
    string input = Console.ReadLine();

	if (password != input && i <= 3)
	{
		Console.WriteLine("Incorrect password. Try again.");
	}
	else if (password == input)
	{
		Console.WriteLine($"User {username} logged in.");
		break;
	}

	if (i == 4)
	{
		Console.WriteLine($"User {username} blocked!");
	}
}