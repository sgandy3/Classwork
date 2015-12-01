using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int numrow = 5;
            int numcol = 5;

            for(int row = 1; row >= numrow ; row++) //outside. print rows 1,2,3,4... until num is reached
            {
                for(int col = 1; numcol <= col++; ) //inside. print col
                {
                    Console.Write((col * row)+ " ");
                }

                Console.WriteLine();
            }


        }
    }
}
