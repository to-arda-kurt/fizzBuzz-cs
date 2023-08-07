using System;

namespace FizzBuzz;

public class Program
{
    static void Main(string[] args)
    {
        var fizzBuzzer = new FizzBuzzer();
        FizzBuzzer.StartFizzBuzz(FizzBuzzer.AskNumber(args));
    }
}