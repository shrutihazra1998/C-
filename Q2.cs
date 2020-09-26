using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    //    Implement the body for the following function:

    //static boolean isPrimeNumber(int num)
    //    {
    //        // do stuff here
    //        return false;
    //    }
    //    The function should check and return true only if the number passed as argument is a prime number.

    //    Write a C# program to call the above function multiple times with different values.
    class Q2
    {
      static bool isPrimeNumber(int num)
        {
            if (num == 0 || num == 1)
                return false;

            for (int i = 2; i < (num-1); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void Main()
        {

            if (isPrimeNumber(0))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Non-Prime");

            if (isPrimeNumber(7))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Non-Prime");

            if (isPrimeNumber(15))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Non-Prime");

        }
    }
}
