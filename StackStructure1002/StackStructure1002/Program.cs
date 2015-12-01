using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStructure1002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<string>newStack=new Stack<string> ();
            //newStack.Push("first element"); //bottom
            //newStack.Push("second element");//middle
            //newStack.Push("third element");//top

            //foreach (string stack in newStack)
            //{
            //    Console.WriteLine(stack);
            //}

            Stack<string> pancakes = new Stack<string>();
            pancakes.Push("flour");
            pancakes.Push("egg");
            pancakes.Push("milk");

            foreach (string pan in pancakes)
            {
                Console.WriteLine(pan);
            }


            Stack<string> lego = new Stack<string>();
            lego.Push("red");
            lego.Push("blue");
            lego.Push("green");

            foreach (string leg in lego)
            {
                Console.WriteLine(leg);
            }




        }
    }
}
