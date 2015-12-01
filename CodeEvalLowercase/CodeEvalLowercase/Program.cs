using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalLowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from file
            string line = "HELLO WORLD";
           
           
            //check loop
            foreach (char l in line)
            {
                if(char.IsLetter(l))
                {
                    return;
                }
               
            }
            return line;

            //if line contains words,print 
            if(bool.Parse(line) == true)
            {
                //change to lowercase
                Console.WriteLine(line.ToLower());
            }



        }
        


    
    }
}
