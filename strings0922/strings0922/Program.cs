using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings0922
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Extraction
            string mystr = "We Can Code IT";

            string code = mystr.Substring(7, 4); //extract the word code. start at index 7. 4 indexes long
            Console.WriteLine(mystr); //print the string mystr
            Console.WriteLine(code); // print the word code


            //Substring Example
            string path = "C://Docs//MyImage.jpg";
            int index = path.LastIndexOf("//");//index = 7
            string justName = path.Substring(index + 1); //justName = "MyImage.jpg" --index + 1 , includes "//" but + 1 moves the start point over 1 index so "//" is not included

             */


            //find length using indexof & lastindexof in substring
            string path = "C://Docs//MyImage.jpg";
            int sIndex = path.LastIndexOf("//"); //index = 7
            sIndex = sIndex + 1; //index = 8. Get from backslash to "M"
            int dIndex = path.LastIndexOf("."); //index 15
            int len = dIndex - sIndex; //length = 7 (15 - 8) 

            string justName = path.Substring(sIndex, len);
            Console.WriteLine(justName);

            //Split Method
            string mystr = "We canCode IT";
            string[] items = mystr.Split(' ');
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }

            //splitting string by mult characters
            string myStr = "We, Can, {Code}, IT";
            char[] separators = new char[] {',',' '};
            string[] splitString =
              myStr.Split(separators, StringSplitOptions.RemoveEmptyEntries); //removes empty spaces

            /*RemoveEmptyEntries removes the additional array items ‘ ‘ caused by the comma and the space delimiters being next to each other in the source string.*/

            foreach (string item in splitString)
            {
                Console.WriteLine(item);
            }
            //try it without StringSplitOptions.RemoveEmptyEntries to compare.







        }
    }
}
