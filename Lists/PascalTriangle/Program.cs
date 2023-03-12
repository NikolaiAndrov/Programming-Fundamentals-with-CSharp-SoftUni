public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var nums = new List<int>();
        nums.Add(1);

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(string.Join(" ", nums));

            if (nums.Count == 1)
            {
                nums.Add(1);
                continue;
            }

            var currentNums = new List<int>();

            for (int j = 0; j < nums.Count - 1; j++)
            {
                var sum = nums[j] + nums[j + 1];

                if (nums.Count == 2)
                {
                    nums.Insert(1, sum);
                    break;
                }

                currentNums.Add(sum);

            }

            if (i >= 2)
            {
                nums.RemoveRange(1, nums.Count - 2);
                nums.InsertRange(1, currentNums);
            }
        }
    }
}