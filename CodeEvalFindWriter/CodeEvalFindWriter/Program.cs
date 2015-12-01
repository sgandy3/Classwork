using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalFindWriter
{
    class Program
    {
        public static void Main()
        {
            //input 
            string writerCode = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg| 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";

            //3Kucdq9bfCEgZGF2nwx8UpzQJyHiOm0hoaYP6ST1WM7Nks5XjrR4IltBeDLV vA| 2 26 33 55 34 50 33 61 44 28 46 32 28 30 3 50 34 61 40 7 1 31


            


            Console.WriteLine(writerCode.Length); //114

            //assign and extract array
            string codeLine1 = writerCode.Substring(0, 63);
            Console.WriteLine(codeLine1);
            
            string codeLine2 = (writerCode.Remove(0,64));
            Console.WriteLine(codeLine2);


            for (int i = 0; i < codeLine1.Length; i++)
            {
                char c = codeLine1[i];
                
                if(c == )


                 Console.Write(c);
                
            }
            
            



        }
    }
}
