using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1015
{
    class Program
    {
        //Write a program which generates and prints on the console 10 random numbers in the range[100, 200].

        static void Main(string[] args)
        {
            Random num = new Random();

            for(int i = 1; i<=10; i++)
            {
                int randomNumber = num.Next(100,200) + 1;
                Console.WriteLine("{0}",randomNumber);
            }



            //Write a program which prints on the console which day of the week is today.
            Console.WriteLine(DateTime.Today.DayOfWeek);




            //Write a program which calculates the area of a triangle with the following given:
            // length of one side and the height to it
         
            double height = 4;
            double side = 5;

            double b = Math.Pow(height, 2);
            double c = Math.Pow(side, 2);

            double a = c - b;

            double tribase = Math.Sqrt(a);

            double area = tribase * height / 2;

            Console.WriteLine(area);

            // lengths of two sides and the angle between them (hint: side - angle - side)

            double triside1 = 5;
            double triside2 = 5;
            //sin cosin

            double triangle = tbase * theight / 2; 



        }
    }
}
