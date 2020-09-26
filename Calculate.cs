using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex06
   {
        static void Func()
        {
            //Console.WriteLine("Enter Value1");
            //double v1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter value2");
            //double v2 = double.Parse(Console.ReadLine());
            //Console.WriteLine($"The Added value is {v1 + v2}");
            double v1 = getDouble("Enter first value");
            double v2 = getDouble("Enter second value");
            double result = addFunc(v1, v2);
            double result2 = subFunc(v1, v2);
            double result3 = mulFunc(v1, v2);
            double result4 = divFunc(v1, v2);
            Console.WriteLine($"The Added value is {result}");
            Console.WriteLine($"The Substracted value is {result2}");
            Console.WriteLine($"The Multiplied value is {result3}");
            Console.WriteLine($"The Divided value is {result4}");



        }
        static double addFunc(double v1, double v2)
        {
            return v1 + v2;
        }
        static double subFunc(double v1, double v2)
        {
            return v1 - v2;
        }
        static double mulFunc(double v1, double v2)
        {
            return v1 * v2;
        }
        static double divFunc(double v1, double v2)
        {
            return v1 / v2;
        }
        static double getDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Func();
        }
    }
}
