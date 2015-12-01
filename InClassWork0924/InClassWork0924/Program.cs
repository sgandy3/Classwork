using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassWork0924
{
    class Program
    {
        //Create methods for +,-,*,/
        //accept user input for two numbers (double)
        //accept user input to call method
        //print result




        static void Main(string[] args)
            //get user input in a string
            //separate string into pieces by dividing at sign
            // if sign is +,-,/,*
            //send to corresponding method


        {
            string problemInput = Console.ReadLine(); //input
            if (problemInput.Contains('+'))
            {
                int a = problemInput.Length;
                int b = problemInput.IndexOf("+");

                

               

                
                string x = problemInput.Substring(0,b-1);
                
                string y = problemInput.Remove(b,a+1);

                Console.WriteLine(x);
                Console.WriteLine(b);

                //add(x, y);
            }


        //}

        //static double add(double x, double y)
        //{
        //    double result = x + y;
        //    Console.WriteLine(result);
        //}

        //static double sub(double x, double y)
        //{
        //    double result = x - y;
        //    Console.WriteLine(result);
        //}

        //static double mult(double x, double y)
        //{
        //    double result = x * y;
        //    Console.WriteLine(result);
        //}

        //static double div(double x, double y)
        //{
        //    double result = x - y;
        //    Console.WriteLine(result);
         }





    }
}
