using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeEvalStackImplementation
{
    class Program
    {
        static void Main(string[] args)
        {


            //create stack   //numbers come out while loop into stack
            Stack<int> numbers = new Stack<int>();

            //read a file---create a loop for StreamReader
            StreamReader reader = new StreamReader("..//..//stackTest.txt"); //open
            using (reader) //close
            {
                while (reader != null)
                {
                    string line = reader.ReadLine();//read file save as line
                    if ( line == null)
                    {
                        break;
                    }


                  //alt

                 //   for(int i=0; i<= line.Length; i++)
                 //   {
                  //      numbers.Push(line[i]);
                 //   }





                    string[] readerSplit = line.Split(' ');//Split reader (string) store in string array 'readerSplit'
                    foreach (string read in readerSplit)
                    {
                        numbers.Push(int.Parse(read)); //push onto stack-- .Push --convert string[] to int

                    }


                    //get numbers out of stack
                    //.count could changing with the pop
                   

                    for (int i = 0; i <= numbers.Count; i++) // i +=2  every other
                    {

                        //print every alternate integer --Console.WL
                        Console.Write(numbers.Peek() + " "); // shows last element
                     
                        numbers.Pop(); //pop current element
                        numbers.Pop();          //pop next element

                    }
                    Console.WriteLine();

                }


               }
        



        }
    }
}
