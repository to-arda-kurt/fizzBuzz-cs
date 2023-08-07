namespace FizzBuzz;

public class FizzBuzzer
{
    public string FizzBuzz(int n)
    {
        string message = "";
        bool dividiblebyThree = IsDividible(n, 3);
        bool dividiblebyFive = IsDividible(n, 5);

        if (dividiblebyThree)
        {
            message = message + "Fizz";
        }

        if (dividiblebyFive)
        {
            message = message + "Buzz";
        }

        if (message.Length == 0)
        {
            message = n.ToString();
        }

        return message;
    }

    public bool IsDividible(int fizzBuzzNumber, int divider)
    {
        return (fizzBuzzNumber % divider) == 0;
    }

    public void startFizzBuzz(int max)
    {
        for (var i = 1; i <= max; i++)
        {
            Console.WriteLine(FizzBuzz(i));
        }
    }
}