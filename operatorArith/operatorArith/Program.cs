using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorArith
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareperimeter = 17;
            double squareSide = squareperimeter/4.0;
            double squareArea = squareSide * squareSide;
            Console.WriteLine(squareSide); // 4.25
            Console.WriteLine(squareArea); // 18.0625

            int a = 5;
            int b = 4;
            Console.WriteLine(a + b); //9
            Console.WriteLine(a + b++); //9
            Console.WriteLine(a + b); //10
            Console.WriteLine(a + (++b)); //11
            Console.WriteLine(a + b); //11

            Console.WriteLine(11 / 3); //3
            Console.WriteLine(11 % 3); //2
            Console.WriteLine(12 / 3); //4
        }
    }
}
