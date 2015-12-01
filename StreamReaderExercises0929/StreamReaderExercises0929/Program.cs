using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderExercises0929
{
    class Program
    {
        static void Main(string[] args)
        {
            //open
            StreamReader reader = new StreamReader("..//..//Sample.txt");

            //read file
            // Read first line from the text file // initialize
            string line = reader.ReadLine();
           

            int lineNumber = 0;

            // Read first line from the text file // initialize
            

            // Read the other lines from the text file //condition
            while (line != null)
            {
                lineNumber++;// update
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }

            // Close the resource after you've finished using it
            reader.Close();
        }



    }
}
