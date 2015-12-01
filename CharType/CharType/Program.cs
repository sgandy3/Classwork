using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharType
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'a';
            Console.WriteLine("The code of '0' is: {1}", symbol, (int)symbol);

            symbol = 'b';
            Console.WriteLine("The code of '0' is: {1}", symbol, (int)symbol);

            symbol = 'A';
            Console.WriteLine("The code of '0' is: {1}", symbol, (int)symbol);
        }
    }
}
