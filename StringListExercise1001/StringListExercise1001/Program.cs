using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringListExercise1001
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] starWars = new string [] {"Yoda","Luke","Darth","Leila" };

            List<string> sciFi = new List<string>(starWars);
            Console.WriteLine(sciFi.Count);

            List<string> space = starWars.ToList();
            Console.WriteLine(space.Count);

            foreach(string star in space)
            {
                Console.WriteLine(star);
            }

            
            
        }

    }
}
