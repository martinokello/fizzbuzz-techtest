using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Interfaces;

namespace FizzBuzz.FizzBuzzConcretes
{
    public class FizzBuzz:IFactors
    {
        private int _fizzBuzzNumber;

        public FizzBuzz(int number)
        {
           _fizzBuzzNumber = number;
        }
        public bool IsFactorOf(int number)
        {
            return _fizzBuzzNumber % number == 0;
        }

        public bool IsFactorOf(int number1, int number2)
        {
            return IsFactorOf(number1) && IsFactorOf(number2);
        }

        public int Number
        {
            get { return _fizzBuzzNumber;
            }
        }
    }
}
