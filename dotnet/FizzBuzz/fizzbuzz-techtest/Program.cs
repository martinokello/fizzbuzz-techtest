using System;
using System.Collections.Generic;

namespace FizzBuzz
{
  class Program
  {
    private static int three = 3;
    private  static int five = 5;

    static void Main(string[] args)
    {

        var fizzBuzz = new FizzBuzzConcretes.FizzBuzz(15);

        var result = GetFizzBuzzMessage(fizzBuzz);
        Console.Out.WriteLine(result);
    }

      private static object GetFizzBuzzMessage(FizzBuzzConcretes.FizzBuzz fizzBuzz)
      {
          return fizzBuzz.IsFactorOf(three, five)
            ? "FizzBuzz"
            : fizzBuzz.IsFactorOf(three) ? "Fizz" : fizzBuzz.IsFactorOf(five) ? "Buzz" : fizzBuzz.Number.ToString();
      }
  }
}


