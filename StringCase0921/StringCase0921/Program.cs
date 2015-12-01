using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCase0921
{
    class Program
    {
        static void Main(string[] args)
        {
           /* string word = "apple";
            string word2 = "Apple";

            int result = word.CompareTo(word2);

            if (result <0)
            {
                Console.WriteLine("lower is before upper");
            
            }

            //2nd option
            string letter = "a";
            string letter2 = "A";
            Console.WriteLine(letter.CompareTo(letter));
            


            //print bool comparison








            /*
                        string name = "Joy";
                        string name2 = "Quetta";


                        //"Joy".CompareTo("Quetta");
                        if (result < 0)
                        {
                            Console.WriteLine("J is before Q");
                        }
                        else
                        {
                            Console.WriteLine("Q is before J");
                        }
                        */


           /* Console.WriteLine(String.Concat("stephanie", "is", "awesome"));

            string greeting = "Howdy";
            string name = "User";

            Console.WriteLine(greeting +" " + name);
            Console.WriteLine(string.Concat(greeting, " ", name));


            //.ToUpper
            //Console.WriteLine(variable.ToUpper());
            //.ToLower
            //COnsole.WriteLine(variable.ToUpper());

            //IndexOf

            string name = "We Can Code IT";
            int index = name.IndexOf("Code");

            Console.WriteLine(index); //7 (index #)


            //LastIndexOf counts backwards

            */

            //case insensitive search for all occurrences of substring.

            string str = “Hello world!I like to “ + “say hello to all my friends.”; //concatenate 2 strings
            str = str.ToUpper(); //change case.

            string search = “HELLO”; //string search equals HELLO
            int position = str.IndexOf(search); //integer position within index
            while (position != -1) // while position is in the string
            {
                Console.WriteLine(search + “  found at ” +position); //print HELLO found at 
                position = str.IndexOf(search, position + 1); //
            }



        }
    }
}
