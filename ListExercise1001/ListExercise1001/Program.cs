using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListExercise1001
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<int> list = new List<int>() { 2, 3, 4, 7 }; //instanciating object called list

            //List<int> birthYear = new List<int>() {1983,1979,1988,1977,1987,1969,1990,1982,1991,1964 };
            //birthYear.Sort();

            //foreach (int year in birthYear)
            //{

            //    Console.Write(year +" ");
            //}

            //List<int> list = new List<int>();
            //list.Add(20);
            //list.Add(50);
            //list.Add(32);
            //list.Add(18);
            //list.Add(26);
            //list.Add(19);
            //list.Add(25);
            //list.Add(28);
            //list.Add(42);
            //list.Add(38);

            //int sum = list.Sum();
            //Console.WriteLine(sum);


            //List<string> names = new List<string> {"Steph","RaQuel","Tori", "Marilee" };
            //names.Add("Sophie");
            //names.Add("Bob");
            //names.Add("Ron");
            //names.Add("David");
            //names.Add("Sara");

            //StreamWriter studentNames = new StreamWriter("..//..//StudentNames.txt");

            //{
            //    foreach (string name in names)

            //    {
            //        studentNames.WriteLine(name);

            //    }
            //}
            //studentNames.Close();

            {
                List<int> list = new List<int>();
                list.Add(2);
                list.Add(3);
                list.Add(5);
                list.Add(7);

                Console.WriteLine(list.Count);
                list.Clear();
                Console.WriteLine(list.Count);

            }
            


        }
    }
}
