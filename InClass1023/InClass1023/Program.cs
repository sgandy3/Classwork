using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HylandTryCatchFinally
{
    class Program
    {
        // what will this print out?
        static void Main(string[] args)
        {
            System.Console.WriteLine(new Program().Foo()); //why "new Program().Foo()"? Research this construct -- constructing new object in same class and chaining Foo method. Unusual and simply tricky.
            System.Console.ReadLine();
        }
        String Foo()
        {
            try
            {
                throw new System.Exception("An Exception"); //throwing exception which results in an exception --class is exception.
                System.Console.Write("Inside Try"); //program cannot see this because it stops at throwing the exception
            }
            catch (System.Exception ex)
            {
                return "HERE - " + ex.Message + " yep."; // return removes from method  --Message is a property of exception class
            }
            finally //goes to finally before returns because of the placement on the stack //finally can close files, clean up memory
            {
                System.Console.Write("Finally");
            }
            return "Outside Try"; //outside scope --ends at finally

        }
    }
}

