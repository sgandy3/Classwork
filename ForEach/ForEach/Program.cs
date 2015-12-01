using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] favFoods = {"sushi","pizza","pancakes","mac and cheese" };
            favFoods.Reverse();

            foreach(string food in favFoods) //name items in string something different
            {
                Console.WriteLine(food);
            }

        }
    }
}
