using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeEvalValidParens
{
    class Program
    {
        static void Main(string[] args)
        {

            //Given a string comprising just of the characters (,),{,},[,] determine if it is well-formed or not.
            //use stack  to see if closer had opening
            StreamReader Parens = new StreamReader("..//..//Parens.txt");
            using (Parens)
            {


               
                while (Parens != null)
                {
                    string line = Parens.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    else
                    if (line == "()")
                    {
                        Console.WriteLine("True");
                    }
                    else
                    if (line == "{}")
                    {
                        Console.WriteLine("True");
                    }
                    else
                     if (line == "[]")
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                    
                  
                }
            }

        
        
         
            
        

        
              
           

        }
    }
}
