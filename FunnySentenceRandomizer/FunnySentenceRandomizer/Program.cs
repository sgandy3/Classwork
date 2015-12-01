using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunnySentenceRandomizer
{
    class Program
    {

        

        static void Main(string[] args)
        {


            //use Arrays as data structure to hold nouns, verbs, prepositional phrases
           
            string[] nouns = { "She ", "He ", "It ", "The cat ", "The mongoose ", "The orange ", "The trampoline ", "Musicians ", "Programmers ", "The shake " };
            string[] verbs = { "ate ", "barbequed ", "chirped ", "collided ", "sang ", "spoke ", "cartwheeled ", "dined ", "watched ", "directed " };
            string[] prepPhrases = { "with the monkeys.", "on the porch.", "under the moon.", "after the storm.", "before the prince.", "over the lake.", "in the gazebo.", "between the lines.", "during the festival.", "with them all." };

            int cont = 0;
            for (int i = 0; i <= cont; i++)
            {

                 //find random array number
                Random rnd = new Random();
                 int noun = rnd.Next(0, 9); // creates a number between 0 and 9
                 int verb = rnd.Next(0, 9);   // creates a number between 0 and 9
                 int prepPhrase = rnd.Next(9);     // creates a number between 0 and 9

                 //match random number in string string array
                 string n = nouns[noun];
                 string v = verbs[verb];
                 string p = prepPhrases[prepPhrase];

                //use StringBuilder for joins
                 StringBuilder sb = new StringBuilder();
                 {
                    sb.Append(n);
                    sb.Append(v);
                    sb.Append(p);

                    Console.WriteLine(sb.ToString()); //Print random sentence
                    Console.WriteLine(" ");
                 }

                    //ask user to exit or continue
                 Console.WriteLine("Type CONTINUE or EXIT");
                 string answer = Console.ReadLine().ToUpper();
                 
                 
                 if (answer == "CONTINUE") //if continue, add 1 and resume loop
                 {
                    cont++;
                 }
                else
                 {
                    Environment.Exit(0); //else exit
                 }


            }

           
            
            
            






        }
    }
}
