using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTextFunctions0921
{
    class Program
    {
        static void Main(string[] args)

        {

           /* string movieName = "My fav movie is\"Kill Bill.\"";
            Console.WriteLine(movieName); */


            /* Console.WriteLine('\a' + movieName);

            string name = "'\t' Steph '\n' Gandy";

           System.Write(name); */


            System.Console.WriteLine("What is your name");//ask for user name

            System.String userName = Console.ReadLine(); //save user name in variable

            System.Console.WriteLine("What is your age"); //ask for user age

            System.String userAge = Console.ReadLine();//save user age in variable

            System.Console.WriteLine(userName + '\n' + userAge);


        }
    }
}
