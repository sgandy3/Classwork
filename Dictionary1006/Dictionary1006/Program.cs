using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1006
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> studentScores = new Dictionary<string,int>();
            studentScores.Add("StudentA", 89);
            studentScores.Add("StudentB", 75);
            studentScores.Add("StudentC", 94);
            studentScores.Add("StudentD", 98);

        

           
            Console.WriteLine(studentScores["StudentC"]); //prints score for studentC

           
            



        }
    }
}
