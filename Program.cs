using System;

namespace FizzBuzz;

public class Program
{
    static void Main(string[] args)
    {
        for (var i = 1; i <= 100; i++)
        {
            bool dividiblebyThree = IsDividible(i, 3);
            bool dividiblebyFive = IsDividible(i, 5);
            string message = "";

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
                message = i.ToString();

            }

            Console.WriteLine(message);
        }


        static bool IsDividible(int fizzBuzzNumber, int divider)
        {
            return (fizzBuzzNumber % divider) == 0;
        }
    }
}