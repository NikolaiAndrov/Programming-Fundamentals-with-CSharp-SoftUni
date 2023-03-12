namespace PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            if (!IsLongEnough(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!IsContainingLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!IsContainingTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (IsLongEnough(password) && IsContainingLettersAndDigits(password) && IsContainingTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsLongEnough(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsContainingLettersAndDigits(string password)
        {
            bool isValid = true;

            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        static bool IsContainingTwoDigits(string password)
        {
            bool isValid = false;
            int counter = 0;

            foreach (var ch in password)
            {
                if (char.IsDigit(ch))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}