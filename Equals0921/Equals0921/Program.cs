using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals0921
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "hello";

            bool strEq = (word1 == word2);
            bool strEq2 = word1.Equals(word2, StringComparison.CurrentCultureIgnoreCase);

            Console.WriteLine(strEq); //false
            Console.WriteLine(strEq2); //false

        }
    }
}
