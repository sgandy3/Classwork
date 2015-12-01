using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Frog
    {
        /*A frog only moves forward, but it can move in steps 1 inch long or in jumps 2 inches long. A frog can cover the same distance using different combinations of steps and jumps.

Write a function that calculates the number of different combinations a frog can use to cover a given distance.

For example, a distance of 3 inches can be covered in three ways: step-step-step, step-jump, and jump-step.*/


        public static int NumberOfWays(int n) //n=number of inches
        {
            try
            {
                int steps = n * 1;
                int jumps = n / 2; // 1 jump
                int stepsLeft = n - jumps * 2; //inches - jumps = steps left

                for (int i = 0; i < steps; i++)
                {
                    Console.Write("step-");
                }

                Console.WriteLine();

                for (int i = 0; i < jumps; i++)
                {
                    Console.Write("jump-");

                }
                for (int t = 0; t < stepsLeft; t++)
                {
                    Console.Write("step-");
                }

                Console.WriteLine();

                for (int i = 0; i < stepsLeft; i++)
                {
                    Console.Write("step-");

                }
                for (int t = 0; t < jumps; t++)
                {
                    Console.Write("jump-");
                }
                //don;t know what to return
            }

            catch
            {

                throw new NotImplementedException("Waiting to be implemented.");
                
                
            }
        }

        public static void Main(string[]args)
        {
            
            Console.WriteLine(NumberOfWays(3));
          
            
            


        }
    }
}
