using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentScore1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter total number of scores to be entered.");
            int totalScores = int.Parse(Console.ReadLine());


            Console.WriteLine("Please enter test scores one at a time. No test score maybe higher than 100. ");
            List<int> testScores = new List<int>(10);

            int test = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < totalScores; i++)
            {
                
                if (int.Parse(Console.ReadLine()) < 100)
                {
                    testScores.Add(test);
                }
                else
                {
                    Console.WriteLine("Error. Test scores may NOT be higher than 100.");
                    testScores.Add(test);
                }
              

                
            }
            StudentScoreSum(testScores); //calls 'StudentScore' Method and passes last number that sum was equal to
            int sum = StudentScoreSum(testScores);
            int average = sum / testScores.Count;

            Console.WriteLine("Total Student Score is: "+ sum + "\nAverage Student Score is: " + average); //Print total score and average score
        }

        static int StudentScoreSum(List<int>testScores) //passing list from Main to StudentScoreSum Method
        {
            int count = 0; //starting point for initalize
            int sum = 0; // total number starting point, will be updated from loop

            
            for (int i = 0; i <= testScores.Count; i++)
            {
                count = i;//counts to length of list
                sum = sum + i; //add element in test score to sum (start at 0) sum = new sum
                
            }
           
            return sum; //returns variable out of method to Main
               
        }

            


     }




}
