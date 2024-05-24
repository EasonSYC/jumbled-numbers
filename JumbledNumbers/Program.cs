internal class Program
{
    const string _promptText = "Input a number to check if it's jumbled: ";
    const string _isJumbleText = "It is a jumbled number, all neighbouring digits differ by a maximum of 1.";
    const string _notJumbleText = "It is not a jumbled number.";
    static void Main()
    {
        string input = string.Empty;
        if (string.IsNullOrWhiteSpace(input) || !input.All(char.IsAsciiDigit))
        {
            Console.WriteLine(_promptText);
            input = Console.ReadLine() ?? string.Empty;
        }

        if (input.Length == 1)
        {
            Console.WriteLine(_isJumbleText);
        }
        else
        {
            int previousInt = input[0] - '0';
            bool isJumbled = true;

            for (int i = 0; i < input.Length; ++i)
            {
                int currentInt = input[i] - '0';
                if (currentInt == previousInt || currentInt == previousInt + 1 || currentInt == previousInt - 1)
                {
                    previousInt = currentInt;
                }
                else
                {
                    isJumbled = false;
                    break;
                }
            }

            if (isJumbled)
            {
                Console.WriteLine(_isJumbleText);
            }
            else
            {
                Console.WriteLine(_notJumbleText);
            }
        }

        return;
    }
}