using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate0922
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Prove that it saves time to use StringBuilder
            //Print the date
            Console.WriteLine(DateTime.Now);
            // Now is a property of DateTime Class. Prints current date/time 
            StringBuilder numSB = new StringBuilder();  // instantiates a new StringBuilder object
            numSB.Append("Build with StringBuilder!");
            for (int i = 0; i < 200000; i++)
            {
                numSB.Append(i);
            }
            Console.WriteLine(DateTime.Now);  // Not long from start to end
            */




            //Prove that it takes longer to use a standard join
            //Print the date
            Console.WriteLine(DateTime.Now);
            // Now is a property of DateTime Class. Prints current date/time 
            string numStr = "";
            numStr += "Build with concatenation.";
            for (int i = 0; i < 200000; i++)
            {
                numStr += i;
            }
            Console.WriteLine(DateTime.Now);  // Not long from start to end














        }
    }
}
