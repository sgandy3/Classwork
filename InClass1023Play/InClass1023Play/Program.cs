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
        String Foo() //no keyword static so new object must be created.
        {
            try
            {
                throw new System.Exception("An Exception");
                System.Console.Write("Inside Try");
            }
            catch (System.Exception ex) 
            {
                return "HERE - " + ex.Message + " yep.";
            }
            finally // executes after try block
            {
                System.Console.Write("Finally");
            }
            return "Outside Try"; //prints when there is no catch --when there is no return statement gets error message

        }
    }
}

