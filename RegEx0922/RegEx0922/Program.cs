using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx0922
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use a regular expression to search for all phone numbers in a string. Replace the phone //numbers with the prefix they all share, and then a bunch of asterisks.

            string doc = "Smith's number: 0898880022\nFranky can be " +
                "found at 0888445566.\nSteven's mobile number: 0887654321";


            string replacedDoc = Regex.Replace(
                doc, "(08)[0-9]{8}", "$1********"); //pattern we are looking for

            Console.WriteLine(replacedDoc);
            // Console output:
            // Smith's number: 08********
            // Franky can be found at 08********.
            // Steven' mobile number: 08********








        }
    }
}
