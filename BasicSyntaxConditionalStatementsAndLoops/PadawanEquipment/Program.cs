double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

int freeBelts = students / 6;
double allLightsaber = lightsaberPrice * Math.Ceiling(students * 1.1);
double allRobe = robePrice * students;
double allBelt = beltPrice * (students - freeBelts);

double totalSum = allLightsaber + allRobe + allBelt;

if (money >= totalSum)
{
    Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
}
else
{
    double neededMoney = Math.Abs(totalSum - money);
    Console.WriteLine($"John will need {neededMoney:F2}lv more.");
}