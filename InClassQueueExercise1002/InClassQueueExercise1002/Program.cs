using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassQueueExercise1002
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> firstQ = new Queue<string>();
            firstQ.Enqueue("first Element");
            firstQ.Enqueue("second Element");
            firstQ.Enqueue("third Element");

            foreach(string q in firstQ)
            {
                Console.WriteLine(q);
            }


           


        }
    }
}
