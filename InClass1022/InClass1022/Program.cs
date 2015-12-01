using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1022
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you right now?");
                int ageNow = int.Parse(Console.ReadLine());
                Console.WriteLine("You will be " + (ageNow + 85) + " at the turn of the next century.");
            }
           finally // catch (System.FormatException notANumber)
            {
                //Console.WriteLine(notANumber.Message); //use this. can put message only
                // throw new FormatException("Well this is awkward...",notANumber); //or this
                Console.WriteLine("goodbye");
            }
            
        }
    }
}
