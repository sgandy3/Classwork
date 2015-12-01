using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryZooAnimals1006
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            zooAnimals.Add("elephant", 2);
            zooAnimals.Add("giraffe", 5);
            zooAnimals.Add("penguin", 10);
            zooAnimals.Add("lion", 2);
            zooAnimals.Add("tiger", 6);
            zooAnimals.Add("bear", 5);
            zooAnimals.Add("turtles", 12);
            zooAnimals.Add("dolphins", 4);
            zooAnimals.Add("killer whale", 1);
            zooAnimals.Add("hippo", 3);


            Console.WriteLine(zooAnimals["turtles"]);

            zooAnimals.Remove("killer whale");

            Console.WriteLine(zooAnimals.Count);

            Console.WriteLine("Enter name of animal.");
            string name = Console.ReadLine();
            if (zooAnimals.ContainsKey(name))
            {
                Console.WriteLine("Yes, it is in the dictionary");
            }
            else
            {
                Console.WriteLine("Would you like to add it? YES or NO");
                string answer = Console.ReadLine().ToUpper();
                if(answer == "YES")
                {

                    zooAnimals.Add(name,1);
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
                
            }
        }
    }
}
