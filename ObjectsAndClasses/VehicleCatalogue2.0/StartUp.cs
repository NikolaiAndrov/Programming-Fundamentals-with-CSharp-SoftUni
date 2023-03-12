public class StartUp
{
    public static void Main()
    {
        List<Catalogue> vehicleCatalogue = new List<Catalogue>();
        AddVehicles(vehicleCatalogue);
        GetVehicleInfo(vehicleCatalogue);
        GetAverageCarHP(vehicleCatalogue);
        GetAverageTruckHP(vehicleCatalogue);
    }

    static void GetAverageTruckHP(List<Catalogue> vehicleCatalogue)
    {
        double hp = 0;
        int count = 0;

        foreach (Catalogue vehicle in vehicleCatalogue)
        {
            if (vehicle.Type == "truck")
            {
                hp += vehicle.HorsePower;
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
        }
        else
        {
            double avg = hp / count;
            Console.WriteLine($"Trucks have average horsepower of: {avg:F2}.");
        }
    }
    static void GetAverageCarHP(List<Catalogue> vehicleCatalogue)
    {
        double hp = 0;
        int count = 0;

        foreach (Catalogue vehicle in vehicleCatalogue)
        {
            if (vehicle.Type == "car")
            {
                hp += vehicle.HorsePower;
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
        }
        else
        {
            double avg = hp / count;
            Console.WriteLine($"Cars have average horsepower of: {avg:F2}.");
        }
    }
    static void GetVehicleInfo(List<Catalogue> vehicleCatalogue)
    {
        string model;

        while ((model = Console.ReadLine()) != "Close the Catalogue")
        {
            foreach (Catalogue vehicle in vehicleCatalogue)
            {
                if (model == vehicle.Model)
                {
                    if (vehicle.Type == "truck")
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                    else if (vehicle.Type == "car")
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
            }
        }
    }
    static void AddVehicles(List<Catalogue> vehicleCatalogue)
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] vehicleInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = vehicleInfo[0];
            string model = vehicleInfo[1];
            string color = vehicleInfo[2];
            double horsePower = double.Parse(vehicleInfo[3]);

            Catalogue catalog = new Catalogue(type, model, color, horsePower);
            vehicleCatalogue.Add(catalog);
        }
    }
}

public class Catalogue
{
    public Catalogue(string type, string model, string color, double horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public double HorsePower { get; set; }
}
