using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StrmWtr0930
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter writer = new StreamWriter("..//..//Answers.txt");

            using(writer)
            {

                writer.WriteLine("Hello World");

                
            }

            StreamReader reader = new StreamReader("..//..//Answers.txt");
            using (reader)
            {
                
                Console.WriteLine(reader);

            }
            
        }
    }
}
