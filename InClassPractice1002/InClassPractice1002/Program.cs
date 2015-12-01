using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassPractice1002
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine(); //read from the console any number
            Stack<int> number = new Stack<int>(); //instanciate new stack called number
            string []inputSplit =  userInput.Split(' ',',');//Split and store in inputSplit
            

            foreach (string num in inputSplit) //print each element in number
            {
                number.Push(int.Parse(num)); //push, convert 
                
            }
            foreach(int num in number)
            {
                Console.Write(num);
            }


        }
    }
}
