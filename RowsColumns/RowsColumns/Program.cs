using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowsColumns
{
    class Program
    {
        static void Main(string[] args)
        {
         int n = int.Parse(Console.ReadLine()); // n = number from console
         for(int row = 1;row <= n; row++)//(outer loop) row starts at 1; loop is true if row is less than or equal to n; add 1 to row after assigning     
            { 
            for (int col = 1; col <= row; col++)//(inner loop) col starts at 1; true if col is equal or less than row; add 1 to col after assigning
            {
                Console.Write(col + " ");//print col plus space but, stay on same line
            }
            Console.WriteLine();//print space, go to next line
         }

        }
    }
}
