using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ex04
    {
        static void Main(string[] args)
        {
            //string[] names = new string[5];
            //for(int i=0; i<names.Length; i++)
            //{
            //    Console.WriteLine("Enter name");
            //    names[i] = Console.ReadLine();
            //}
            //foreach (string name in names)
            //    Console.WriteLine(name);
            //int[] data = { 234, 345, 789, 4, 345, 2, 34, 56, 7 }; //another way to create arrays
            //foreach (int val in data) Console.WriteLine(val);

            //multi dimensional array
            //int[,] TwoD = new int[,]
            //{
            //    {1, 2 ,3 },
            //    {4, 5, 6 },
            //    {7, 8, 9 }
            //}; //3x3
            //Console.WriteLine("Dimensions" + TwoD.Rank);
            //Console.WriteLine("1st Dimension" + TwoD.GetLength(0));
            //Console.WriteLine("2nd Dimension" + TwoD.GetLength(1));
            //for (int i=0; i< TwoD.GetLength(0); i++) //Martrix Display
            //    {
            //    for (int j=0; j < TwoD.GetLength(1); j++)
            //        {
            //        Console.Write(TwoD[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Jagged Arrays
            //Array of Arrays is called Jagged Arrays
            //In this case you have a fixed number of rows, but variable  number of columns

            int[][] School = new int[5][]; //5 rows
            School[0]= new int[] {45,55,56,89,78,65 };
            School[1]= new int[] {12,56,34 };
            School[2]= new int[] {12,56,34,78,90 };
            School[3]= new int[] {34,67 };
            School[4]= new int[] { 23,89,54};
            //Each row is an independent array
            for(int i=0; i<School.Length; i++)
            {
                foreach (int no in School[i])
                    Console.Write(no + " ");
                Console.WriteLine();
            }
        }
    }
}
