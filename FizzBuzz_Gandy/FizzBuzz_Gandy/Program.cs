using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Gandy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for Fizz");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a number for Buzz");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the highest number to count");
            int z = Convert.ToInt32(Console.ReadLine());

            int number;

            int[] numData = new int[z];
           

            for (number = 0; number < numData.Length; number++)
            {
                 

                if ((number % x == 0) && (number % y == 0)) //If x & y are divisible by number
                {
                  Console.Write(" FB "); // Print Fizz Buzz
                }
                else
               {

                    if (number % y == 0) // If number is divisible by y
                    {
                        Console.Write(" F "); // Print Fizz
                    }

                    else
                    
                        if (number % x == 0) // If number is divisible by x
                        {
                           Console.Write(" B "); //Print Buzz
                        }
                        

                    else
                    {
                        Console.Write(number); // restart loop
                    }

                }
             }  



                
        }
    }
}
