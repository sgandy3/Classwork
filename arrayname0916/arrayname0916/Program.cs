using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayname0916
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lastName = {'g','a','n','d','y'};
            
            Console.WriteLine(lastName.Length);

            Console.WriteLine(lastName[(lastName.Length) -2]);
        }
    }
}
