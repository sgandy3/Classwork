using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumeral0925
{
    class Program
    {
        static void Main(string[] args)
        {


            // // Store integer 182
            //int decValue = 182;
            //// Convert integer 182 as a hex in a string variable
            //string hexValue = decValue.ToString("X");
            //Console.WriteLine(hexValue);

            //// Convert the hex string back to the number
            //int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine(decAgain);

            //int myInt = 2934;
            //string myHex = myInt.ToString("X");  // gives you hex
            //int myNewInt = Convert.ToInt32(myHex, 16);  // back to int again.



            int numbers = 110;
            string binary = Convert.ToString(numbers,2);
            Console.WriteLine(binary);

          
            int revbinary = Convert.ToInt32(binary, 2);
            Console.WriteLine(revbinary);



          
            


        }
    }
}
