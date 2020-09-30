using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Delegates are like function pointers of C++. They are used to represent methods as arguments to a function. Delegates are created as reference types. They are used as parameters of a certain method that should expect a method as an arg. While invoking the method, the instance of the delegate is created which will internally refer to any method that matches the signature of the delegate. And U will invoke the method. 
//Delegates are declared like a method. A signature of a delegate comes with a delegate keyword followed by a typical function signature. 
namespace ConsoleApp1
{
    delegate double operation(double v1, double v2);
    class Delegates
    {
        internal static double getDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }
        public static void InvokeMathOperation(operation method)
        {
            double v1 = getDouble("Enter the first value");
            double v2 = getDouble("Enter the second value");
           // if (method == null)
             //   throw new Exception("No method is passed");
            var result = method(v1, v2);
            Console.WriteLine("The result: " + result);
        }
        static void Main(string[] args)
        {
            InvokeMathOperation(addFunc);
        }

        static double addFunc(double v1, double v2) => v1 + v2;
    }
}
