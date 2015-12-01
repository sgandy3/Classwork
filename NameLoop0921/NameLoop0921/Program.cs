using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameLoop0921
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?"); //ask user for name
            string name = Console.ReadLine(); // user enters name

            foreach (char letter in name) //loop over each character
            {
                Console.WriteLine(letter); //print each character as a line
            }



            Console.WriteLine("What is your first name?"); //ask
            string firstName = Console.ReadLine(); //read
            int nameLength = firstName.Length; // get the length of the string

            for (int i = 0; i < nameLength;i++) // create loop using the length of the string
            {
                Console.WriteLine(firstName[i]); //print index from string
            }



        }
    }
}
