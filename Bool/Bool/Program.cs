using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lightSwitch = true;
            bool lamp = true;

            Console.WriteLine(lightSwitch && lamp); //true

            Console.WriteLine(lightSwitch || lamp); //true

            Console.WriteLine(! lightSwitch); // false

            Console.WriteLine(lightSwitch ^ lamp); //false
        }
    }
}
