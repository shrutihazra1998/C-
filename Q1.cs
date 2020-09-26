using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
//    Implement the body for the following function:

//static boolean isValidDate(int year, int month, int day)
//{
//// do stuff here
//return false;
//}
//The function should check if the parameter values constitute a valid calendar date or not.Accordingly return true or false.

//For example,

//year= 2018, month= 13, day= 1 is an invalid date as the possible values for month is 1 to 12.
//year= 2018, month= 2, day= 29 is an invalid date as the maximum days in February is 28 in the year 2018
//year= 2016, month= 2, day= 29 is a valid date.
//Write a C# program to call the above function multiple times with different values.
{
    class Q1
    {
        static bool isLeap(int lyear)
        {
            return (((lyear % 4 == 0) &&
                     (lyear % 100 != 0)) ||
                     (lyear % 400 == 0));
        }


        static bool isValidDate(int year, int month, int day)
        {
            if (month < 1 || month > 12)
                return false;
            if (day < 1 || day > 31)
                return false;


            if (month == 2)
            {
                if (isLeap(year))
                    return (day <= 29);
                else
                    return (day <= 28);
            }

            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return (day <= 30);
            }

            return true;
        }
        public static void Main()
        {

            if (isValidDate(2020, 09, 25))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            if (isValidDate(2019, 02, 29))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
