using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLoop0921
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            int len = s.Length; //5
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
