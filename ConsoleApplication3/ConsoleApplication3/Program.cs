using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[]birthMonths ={ "October","July","October","May"};
            // Console.WriteLine(Array.IndexOf(birthMonths, "October"));


            // string[] firstName = {"Sammy", "Bob", "Brent" };
            // Console.WriteLine(Array.IndexOf(firstName,"Bob"));

            // int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //  Console.WriteLine(Array.LastIndexOf(numbers, 4));

            //  int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //  Array.Reverse(numbers);
            //  Console.WriteLine(numbers[0]);

            //char[] alpha = { 'a', 'b', 'c', 'd', 'e' };
            //Console.WriteLine(alpha [0]);

            //Array.Reverse(alpha);
            //Console.WriteLine(alpha[0]);

            /* int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
             Array.Sort(numbers);
             Console.WriteLine(numbers[0]+ " "+ numbers[1]+ " " + numbers[2]);
             Console.WriteLine(numbers[7]);
      */

            //  string[] names = {Rae,Steph,Amy,Raquel };




            string[] days = { "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat", "Sun" };
            int i;

            for (i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }




        }
    }
}
