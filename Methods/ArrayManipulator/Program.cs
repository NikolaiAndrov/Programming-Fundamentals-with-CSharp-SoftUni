namespace ArrayManipulator
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = args[0];

                if (command == "exchange")
                {
                    int index = int.Parse(args[1]);

                    if (index < 0 || index >= nums.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    nums = ExchangeArray(nums, index);
                }
                else if (command == "max")
                {
                    string secondCommand = args[1];

                    if (secondCommand == "even")
                    {
                        int maxIndex = IndexOfMaxEvenNumber(nums);

                        if (maxIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(maxIndex);
                    }
                    else if (secondCommand == "odd")
                    {
                        int maxIndex = IndexOfMaxOddNumber(nums);

                        if (maxIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(maxIndex);
                    }
                }
                else if (command == "min")
                {
                    string secondCommand = args[1];

                    if (secondCommand == "even")
                    {
                        int minIndex = IndexOfMinEvenNumber(nums);

                        if (minIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(minIndex);
                    }
                    else if (secondCommand == "odd")
                    {
                        int minIndex = IndexOfMinOddNumber(nums);

                        if (minIndex == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }

                        Console.WriteLine(minIndex);
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(args[1]);
                    string secondCommand = args[2];

                    if (count > nums.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (secondCommand == "even")
                    {
                        GetFirstNEvenNumbers(nums, count);
                    }
                    else if (secondCommand == "odd")
                    {
                        GetFirstNOddNumbers(nums, count);
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(args[1]);
                    string secondCommand = args[2];

                    if (count > nums.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    if (secondCommand == "even")
                    {
                        GetLastNEvenNumbers(nums, count);
                    }
                    else if (secondCommand == "odd")
                    {
                        GetLastNOddNumbers(nums, count);
                    }
                }
            }

            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        static void GetLastNOddNumbers(int[] nums, int count)
        {
            int currentCount = 0;
            List<int> currentNums = new List<int>();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 != 0)
                {
                    currentNums.Add(nums[i]);
                    currentCount++;
                }

                if (currentCount == count)
                {
                    break;
                }
            }
            currentNums.Reverse();
            Console.WriteLine($"[{string.Join(", ", currentNums)}]");
        }
        static void GetLastNEvenNumbers(int[] nums, int count)
        {
            int currentCount = 0;
            List<int> currentNums = new List<int>();

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 0)
                {
                    currentNums.Add(nums[i]);
                    currentCount++;
                }

                if (currentCount == count)
                {
                    break;
                }
            }
            currentNums.Reverse();
            Console.WriteLine($"[{string.Join(", ", currentNums)}]");
        }
        static void GetFirstNOddNumbers(int[] nums, int count)
        {
            int currentCount = 0;
            List<int> currentNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    currentNums.Add(nums[i]);
                    currentCount++;
                }

                if (currentCount == count)
                {
                    break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", currentNums)}]");
        }
        static void GetFirstNEvenNumbers(int[] nums, int count)
        {
            int currentCount = 0;
            List<int> currentNums = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    currentNums.Add(nums[i]);
                    currentCount++;
                }

                if (currentCount == count)
                {
                    break;
                }
            }

            Console.WriteLine($"[{string.Join(", ", currentNums)}]");
        }
        static int IndexOfMinOddNumber(int[] nums)
        {
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    if (nums[i] <= min)
                    {
                        min = nums[i];
                        index = i;
                    }
                }
            }

            return index;
        }
        static int IndexOfMinEvenNumber(int[] nums)
        {
            int min = int.MaxValue;
            int index = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    if (nums[i] <= min)
                    {
                        min = nums[i];
                        index = i;
                    }
                }
            }

            return index;
        }
        static int IndexOfMaxOddNumber(int[] nums)
        {
            int max = int.MinValue;
            int index = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    if (nums[i] >= max)
                    {
                        max = nums[i];
                        index = i;
                    }
                }
            }

            return index;
        }
        static int IndexOfMaxEvenNumber(int[] nums)
        {
            int max = int.MinValue;
            int index = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    if (nums[i] >= max)
                    {
                        max = nums[i];
                        index = i;
                    }
                }
            }

            return index;
        }
        static int[] ExchangeArray(int[] nums, int index)
        {
            int[] currentNums = new int[nums.Length];
            int currentIndex = 0;

            for (int i = index + 1; i < nums.Length; i++)
            {
                currentNums[currentIndex] = nums[i];
                currentIndex++;
            }

            for (int i = 0; i <= index; i++)
            {
                currentNums[currentIndex] = nums[i];
                currentIndex++;
            }

            return currentNums;
        }
    }
}