using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "Ivan";
            string lastName = "Ivanov";
             Console.WriteLine("Hello, {0}!\n", firstName);

             string fullname = firstName + " " + lastName;
             Console.WriteLine("Your full name is {0}.", fullname);

            Console.WriteLine("Hello" +" " + firstName +" "+ lastName);


        }
    }
}
