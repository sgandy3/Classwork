using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork0915
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter score"); //ask age
            int score = Convert.ToInt32(Console.ReadLine());

            if (score = 1 == < 9) 

            //score system
            else if (score = (1 == < 3))
            {
                Console.WriteLine(score * 10);
            }
            else if (score = 4 == < 6)
            {
                Console.WriteLine(score * 100);
            }
            else if (score = 7 == < 9)

            {
                Console.WriteLine(score * 1000);
            }


            }
            else
            {
                //if score is outside 1 and 9
                Console.WriteLine("error");


            }

        }

        }
    }
}
