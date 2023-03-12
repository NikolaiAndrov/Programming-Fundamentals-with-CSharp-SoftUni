public class StartUp
{
    public static void Main()
    {
        var plates = new HashSet<string>();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var command = args[0];
            var plate = args[1];

            if (command == "IN")
            {
                plates.Add(plate);
            }
            else if (command == "OUT")
            {
                plates.Remove(plate);
            }
        }

        if (plates.Count > 0)
        {
            foreach (var plate in plates)
            {
                Console.WriteLine(plate);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}