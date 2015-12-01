using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop20917
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Count from 1 to 10
             for (int i =;i <= 10; i++) 

             {
                 //in loop body. Print numbers (i)
                 Console.WriteLine(i);
             } */


            //for loop to calc n to the power or m
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("To the power of?");
            int m = int.Parse(Console.ReadLine());
            int result = 1; //initialize result

            for (int i =0;i< m;i++)
            {
                result *= n;
            }Console.WriteLine(result);
        }
    }
}
