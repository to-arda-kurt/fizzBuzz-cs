namespace FizzBuzz;

public class FizzBuzzer
{
    static readonly List<int> rules = new List<int>();
    public static string FizzBuzz(int n)
    {
        List<string> message = new List<string>();

        bool dividiblebyThree = IsDividible(n, 3);
        bool dividiblebyFive = IsDividible(n, 5);
        bool dividiblebySeven = IsDividible(n, 7);
        bool dividiblebyEleven = IsDividible(n, 11);
        bool dividiblebyThirteen = IsDividible(n, 13);
        bool dividiblebySeventeen = IsDividible(n, 17);

        if (dividiblebyThree && rules.Contains(3))
        {
            message.Add("Fizz");
        }

        if (dividiblebyFive && rules.Contains(5))
        {
            message.Add("Buzz");
        }

        if (dividiblebySeven && rules.Contains(7))
        {
            message.Add("Bang");
        }

        if (dividiblebyEleven && rules.Contains(11))
        {
            message = new List<string>() { "Bong" };
        }

        if (dividiblebyThirteen && rules.Contains(13))
        {
            var itemIndex = message.FindIndex(x => StartsWith(x));

            if (itemIndex == -1)
            {
                message.Add("Fezz");
            }
            else
            {
                message = message.GetRange(0, itemIndex)
                                    .Concat(new List<string>() { "Fezz" })
                                    .Concat(message.GetRange(itemIndex, message.Count - itemIndex))
                                    .ToList();
            }
        }

        if (dividiblebySeventeen && rules.Contains(17))
        {
            message.Reverse();
        }

        if (message.Count == 0)
        {
            message = new List<string>() { n.ToString() };
        }

        return message.Aggregate((a, b) => a + b);
    }

    public static bool IsDividible(int fizzBuzzNumber, int divider) => (fizzBuzzNumber % divider) == 0;

    public static void StartFizzBuzz(int max)
    {
        for (var i = 1; i <= max; i++)
        {
            Console.WriteLine(FizzBuzz(i));
        }
    }


    public static bool StartsWith(string word)
    {
        return word.StartsWith("b", StringComparison.InvariantCultureIgnoreCase);
    }

    public static int AskNumber(string[] args)
    {
        bool result;
        string maxInput;
        int max = 200;

        do
        {
            Console.WriteLine("Enter max number:");
            maxInput = Console.ReadLine();
            result = int.TryParse(maxInput, out max);

        } while (!result);


        foreach (var rule in args)
        {
            rules.Add(int.Parse(rule));
        }


        return max;
    }
}