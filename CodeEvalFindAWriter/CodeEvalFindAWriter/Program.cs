using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeEvalFindAWriter
{
    class Program
    {
        public static void Main()
        {
            
            string writerCode1 = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg | 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53 ";
            string writerCode2 "3Kucdq9bfCEgZGF2nwx8UpzQJyHiOm0hoaYP6ST1WM7Nks5XjrR4IltBeDLV vA| 2 26 33 55 34 50 33 61 44 28 46 32 28 30 3 50 34 61 40 7 1 31";

            
            
           string[] leftCode1 = writerCode1.Split(0,64);
            Console.WriteLine(leftCode1.Length);


            foreach (string match in substrings)
            {
                foreach (i= 0;i<) ;

                Console.WriteLine(substrings);
            }
           
           

            int x = writerCode1.Length; //116
            int y = writerCode2.Length; //126
         
            //find the '|' to spilt the data by using the index to find the index
            int Row1 = writerCode1.IndexOf('|'); //64
            int Row2 = writerCode2.IndexOf('|'); //63
            //Console.WriteLine(Row1); 
            //Console.WriteLine(Row2); 

            string[] code = writerCode1('|');
            for (int i = 0; i < code.Length;i++)
            {

            }
           
            //split the array by using substring method
            string leftCode1 = writerCode1.Substring(0,Row1-1);
            Console.WriteLine(leftCode1);
            string rightCode1 = writerCode1.Substring(Row1, x);
            Console.WriteLine(rightCode1);

            string leftCode2 = writerCode2.Substring(0,Row2-1);
            Console.WriteLine(leftCode2);
            string rightCode2 = writerCode2.Substring(Row2+1,y);
            Console.WriteLine(rightCode2);


    


    

    









        }
    }
}
