using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopnumbercount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter starting number");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ending number");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            while (x <= y)
            {
                Console.WriteLine(x);
                x++;
            }

        }
    }
}
