using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            for(int row = 1; row <= n; row++) //row =1, do until 1=4, increment by 1
            {
                for(int col =0; col <= n - 1; col++) //col =0, do until 1=4 (-1) because starting at 0 (which equal 5 numbers), increment by 1
                {
                    Console.Write((col + row) + " ");//print col + row + space
                }


                Console.WriteLine();// print empty line
            }
        }
    }
}
