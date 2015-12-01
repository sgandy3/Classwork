using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalWordToDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "zero;two;five;seven;eight;four";
            string[] strAry = line.Split(';');

            Dictionary<string, int> numString = new Dictionary<string, int>();
            numString.Add("zero", 0);
            numString.Add("one", 1);
            numString.Add("two", 2);
            numString.Add("three", 3);
            numString.Add("four", 4);
            numString.Add("five", 5);
            numString.Add("six", 6);
            numString.Add("seven", 7);
            numString.Add("eight", 8);
            numString.Add("nine", 9);

            
            foreach(string str in strAry)
            {
                int value;
                if(numString.TryGetValue(str,out value))
                {
                    Console.Write(value);
                }
                
            }
            Console.WriteLine();
        }
    }
}
