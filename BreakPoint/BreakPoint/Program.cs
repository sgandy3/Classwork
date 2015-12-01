using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            while (true)

            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! =" + factorial);*/




            int n = int.Parse(Console.ReadLine()); //initialize & declare. Read from console change to int
            decimal factorial = 1; //
            do
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--; // minus  1 on the loop
            } while (true);//this loop has semi-colon

            Console.WriteLine("n!=" + factorial);//print n! and factorial number
           


        }
    }
}
