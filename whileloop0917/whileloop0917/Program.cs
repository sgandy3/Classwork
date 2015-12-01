using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop0917
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int counter = 0;
             while(counter < 10)
             {
                 Console.WriteLine(counter);
                 counter++;
             }
             */

            int sum = 0; //initialzing and declaration
            int counter = 1; //initializing and declaration
            while (counter <= 10) //while counter is less than or equal to 10
            {
                sum += counter++; //add sum to sum = counter and increment counter
                
            }
            Console.WriteLine(sum); //print sum



        }
    }
}
