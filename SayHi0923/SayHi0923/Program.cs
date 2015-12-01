using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHi0923
{
    class Program
    {
        static void Main(string[]args) //goes to main first
        {
            SayHi(); //call SayHi method
           Console.WriteLine(Add(3,5)); //call Add method. Pass method 2 integers
        }

        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        static int Add(int x, int y)
        {

            int sum = x + y;
            return sum; 
        }





    }
}
