using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzChallenge
{
    public class FizzBuzz
    {
        public string FizzBuzz(int num)
        {
            num = Console.ReadLine();

            if (num % 3 == 0)
            {
                return "fizz";
            }

            if (num % 5 == 0)
            {
                return "buzz";
            }

            if ((num % 3 == 0) && (num % 5 == 0))
            {
                return "fizzbuzz";
            }

            else
            {
                return "Error: Did not input correctly.";
            }
        }
    }
}