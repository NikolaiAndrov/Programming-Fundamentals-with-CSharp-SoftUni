public class StartUp
{
    public static void Main()
    {
        var carCollection = new Dictionary<string, List<int>>();
        StoreCarInfo(carCollection);

        string input;

        while ((input = Console.ReadLine()) != "Stop")
        {
            var args = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var car = args[1];

            if (command == "Drive")
            {
                var distance = int.Parse(args[2]);
                var fuel = int.Parse(args[3]);

                Drive(carCollection, car, distance, fuel);
            }
            else if (command == "Refuel")
            {
                var fuel = int.Parse(args[2]);

                Refuel(carCollection, car, fuel);
            }
            else if (command == "Revert")
            {
                var kilometers = int.Parse(args[2]);

                Revert(carCollection, car, kilometers);
            }
        }

        PrintCarInfo(carCollection);
    }

    static void PrintCarInfo(Dictionary<string, List<int>> carCollection)
    {
        foreach (var car in carCollection)
        {
            Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
        }
    }

    static void Revert(Dictionary<string, List<int>> carCollection, string car, int kilometers)
    {
        if (carCollection.ContainsKey(car))
        {
            if (carCollection[car][0] - kilometers < 10000)
            {
                carCollection[car][0] = 10000;
            }
            else
            {
                carCollection[car][0] -= kilometers;
                Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
            }
        }
    }
    static void Refuel(Dictionary<string, List<int>> carCollection, string car, int fuel)
    {
        if (carCollection.ContainsKey(car))
        {
            if (carCollection[car][1] + fuel > 75)
            {
                var diff = 75 - carCollection[car][1];
                carCollection[car][1] = 75;
                Console.WriteLine($"{car} refueled with {diff} liters");
            }
            else
            {
                carCollection[car][1] += fuel;
                Console.WriteLine($"{car} refueled with {fuel} liters");
            }
        }
    }
    static void Drive(Dictionary<string, List<int>> carCollection, string car, int distance, int fuel)
    {
        if (carCollection.ContainsKey(car))
        {
            if (carCollection[car][1] < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else if (carCollection[car][1] >= fuel)
            {
                carCollection[car][0] += distance;
                carCollection[car][1] -= fuel;
                Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                if (carCollection[car][0] >= 100000)
                {
                    carCollection.Remove(car);
                    Console.WriteLine($"Time to sell the {car}!");
                }
            }
        }
        
    }
    static void StoreCarInfo(Dictionary<string, List<int>> carCollection)
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            var model = args[0];
            var mileage = int.Parse(args[1]);
            var fuel = int.Parse(args[2]);

            if (!carCollection.ContainsKey(model))
            {
                carCollection[model] = new List<int>();
                carCollection[model].Add(mileage);
                carCollection[model].Add(fuel);
            }
        }
    }
}