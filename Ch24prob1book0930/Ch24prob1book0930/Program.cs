using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ch24prob1book0930
{
    class Program
    {
        static void Main(string[] args)
        {

            //Open HTML file
            StreamReader reader = new StreamReader("..//..//HTML.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                string final = "";

                //loop over file line by line
                while (line != null)
                {

                    //look for < and >get index of each
                    int start = line.IndexOf('<');
                    int end = line.IndexOf('>');
                    while (end != -1)
                    {

                        //now get length to put in remove method
                        int len = end - start + 1;




                    }



                    //remove string
                    final += line.Remove(start, len);
 
                    line = reader.ReadLine();
                }

                Console.WriteLine(final);

            }










            //string web = "<h1>Hi</h1>";

            //int lBrace = web.LastIndexOf('<');
            //int rBrace = web.IndexOf('>')+1;
            //string a = web.Substring(rBrace, lBrace);
            //Console.WriteLine(a);

            Regex regex = new Regex(@"\d+");
	Match match = regex.Match("Dot 55 Perls");
	if (match.Success)
	{
	    Console.WriteLine(match.Value);
	}
             



            
            ////in class example
            //string test = "<h1>Hi";
            //int start = test.IndexOf('<');
            //int end = test.IndexOf('>');
            //int len = end - start;
            //string newStr = test.Remove(start, len);
            //Console.WriteLine(newStr);

        




        }
    }
}
