using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPracticeP670
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> candy = new Stack<string>();
            candy.Push("lollipop"); //add element to stack
            candy.Push("gum");
            candy.Push("chocolate");
            candy.Push("gummy bear");
            candy.Pop();//remove last element from stack
            Console.WriteLine(candy.Peek()); //returns last element as string
            Console.WriteLine(candy.Count()); //returns int
            //candy.Clear(); //removes element from stack returns 'int 0'
            Console.WriteLine(candy.Count());

            //candy.ToArray();

            if (candy.Contains("gum")) //check if stack contains the element
            {
                Console.WriteLine("yes");
            }

            foreach (string c in candy)
            {
                
                Console.WriteLine();
            }



        }
    }
}
