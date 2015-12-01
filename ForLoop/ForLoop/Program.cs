using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number  = { 2, 3, 6, 87, 9 };
            int i;

            for(i=0; i < number; i++ )
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
