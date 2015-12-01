using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCoatCheck1006
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //create dictionary with 10 elements
            Dictionary<int, string> coatCheck = new Dictionary<int,string>();
            coatCheck.Add(10,"fur");
            coatCheck.Add(20, "peacoat");
            coatCheck.Add(30, "zipper");
            coatCheck.Add(40, "moto");
            coatCheck.Add(50, "varsity");
            coatCheck.Add(60, "leather");
            coatCheck.Add(70, "polyester");
            coatCheck.Add(80, "hooded");
            coatCheck.Add(90, "down");
            coatCheck.Add(100, "rain");

            //Print all elements to console
            foreach (KeyValuePair<int,string> coat in coatCheck)
            {
                Console.WriteLine(coat);
            }

            

        }
    }
}
