namespace TheLift
{
    internal class Program
    {
        static void Main()
        {
            var people = int.Parse(Console.ReadLine());

            var lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4 && people > 0)
                {
                    var diff = 4 - lift[i];

                    if (diff <= people)
                    {
                        lift[i] += diff;
                        people -= diff;
                    }
                    else
                    {
                        lift[i] += people;
                        people = 0;
                        break;
                    }
                }
            }

            var capacity = lift.Length * 4;

            if (people == 0 && lift.Sum() < capacity)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0 && lift.Sum() == capacity)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (lift.Sum() == capacity && people == 0)
            {
                Console.WriteLine(string.Join(" ", lift));
            }
        }
    }
}
