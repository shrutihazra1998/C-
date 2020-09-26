using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex02
    {
        static void Main(string[] args)
        {
            int value = 123;
            Console.WriteLine("the value is" + value);

            double dVal = 234.456;
            Console.WriteLine("the double value is" + dVal);
            float fVal = 34.6f;
            Console.WriteLine(fVal);


            int bigInt = int.MaxValue;// using the wrapper class's const val which gives max val of int
            Console.WriteLine("the max val of int is" + bigInt);
            Console.WriteLine("the range of int is {0} to {1}", int.MinValue, int.MaxValue);
        }
    }
}
