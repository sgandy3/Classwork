using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrmRdEx0929
{
    class Program
    {
        static void Main(string[] args)
        {
            //open
            StreamReader reader = new StreamReader("..//..//ThreeLines.txt");
            using (reader)
            { //read file
              // Read first line from the text file // initialize
                string line = reader.ReadLine();

                int lineNumber = 0; //iterator

                // Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;// update
                    Console.WriteLine("{1}", lineNumber, line);
                    line = reader.ReadLine();

                    //example
                    var foos = "Foo1,Foo2,Foo3";
                    var fooArray = foos.Split(',');  // now you have an array of 3 strings


                    //split
                    line.Split(',');

                    string[] noun = new string[] { "{1}", line };
                    ;
                    Console.WriteLine(noun);





                }

            }
          


              






            

        }
    }
}
