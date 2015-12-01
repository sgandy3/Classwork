using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScoresEx1001
{
    class Program
    {
        static void Main(string[] args)
        {




            //try //give it a try
            //{
            //    Console.WriteLine("please enter scores separated by space");
            //}
            //catch(FormatException)
            //{
            //    Console.Error.WriteLine("Test score is not in correct format");
            //}

            //if (testScore > 100) //if score is more than 100
            //{
            //    Console.WriteLine("Please enter test score between 0 and 100.");
            //}


            //read from console 10 scores between 0<100 (int)
            int[] testScore = new int[10];

            for (int i = 0; i < testScore.Length; i++)
            {
                testScore[i] = int.Parse(Console.ReadLine());
            }

            //make list
            List<int> scores = new List<int>(testScore);

            //read each number from list to calculate i.e. loop through each number.
            for (int i = 0; i <= scores.Count; i++)
            {

                //Calculate sum of list

                int num = 0;
                int sum = 0;
                sum = sum + num;
                }
                foreach (int score in scores)
                {
                //read each number and store into variable num
                int num = score;
                Console.WriteLine(score);
                }
            }

            //Calculate average of list
            int average = (sum / scores.Count);

            //print sum and average
            Console.WriteLine("Student test score sum is: " + sum + "\nStudent test score average is: "+average);
            
        }
    }
}
