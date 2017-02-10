using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Interfaces
{
    public interface IFactors
    {
        bool IsFactorOf(int number);
        bool IsFactorOf(int number1, int number2);
    }
}
