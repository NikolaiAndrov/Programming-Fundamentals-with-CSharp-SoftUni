int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int allMinutes = (hours * 60) + 30 + minutes;

int h = allMinutes / 60;
int min = allMinutes % 60;

if (h == 24)
{
    h = 0;
}

Console.WriteLine($"{h}:{min:D2}");