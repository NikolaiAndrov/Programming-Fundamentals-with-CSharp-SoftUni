internal class Program
{
    private static void Main()
    {
        var circuit = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        float leftCar = 0;
        float rightCar = 0;


        for (int i = 0; i < circuit.Length / 2; i++)
        {
            leftCar += circuit[i];

            if (circuit[i] == 0)
            {
                leftCar *= 0.8f;
            }

            rightCar += circuit[circuit.Length - 1 - i];

            if (circuit[circuit.Length - 1 - i] == 0)
            {
                rightCar *= 0.8f;
            }
        }

        if (leftCar < rightCar)
        {
            Console.WriteLine($"The winner is left with total time: {leftCar}");
        }
        else if (rightCar < leftCar)
        {
            Console.WriteLine($"The winner is right with total time: {rightCar}");
        }
    }
}