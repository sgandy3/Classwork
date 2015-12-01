using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int x = 4;
            //int y = 3;

            //if (x > y)
            // {
            //  Console.WriteLine("{0} is greater than {1}", x, y);
            //}


            // int x = 4;
            // int y = 3;

            // if (x <= y)
            //  {
            //      Console.WriteLine("{0} is less than or equal to {1}", x, y);
            // }
            //  else
            //  {
            //      Console.WriteLine("{0} is NOT less than or equal to {1}", x, y);
            //  }


            // int age = 20;


            //  if (age > 17)
            //  {
            //     Console.WriteLine("See Movie");
            // }
            // else
            //  {
            //    Console.WriteLine("Too young");
            //   }


           // Console.WriteLine("Please enter name with first letter capitalized");

          //  string userName = Console.ReadLine();


         //   if (userName[0] == 'A')
         //   {
                Console.WriteLine("Go to Front Of Line");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Stay in Line");
            //}



            //  Console.WriteLine("Plese enter age");
            //  int age = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine("Plese enter height in decimal form");
            //  double height = Convert.ToDouble(Console.ReadLine());


            // if(age >= 18 && height >= 5.0)
            //  {
            //      Console.WriteLine("You can ride");
            //    }
            //   else
            //   {
            //      Console.WriteLine("You cannot ride");
            //   }


            Console.WriteLine("Please enter age"); //ask age
            int age = Convert.ToInt32(Console.ReadLine()); //convert variable age to integer

            if (age == 16)// if 
            {
                Console.WriteLine("You can drive");
            }
            else //if age is over or under 18
            {
                if (age > 18)
                {
                    Console.WriteLine("You're an adult");
                }

                else
                {

                    if (age < 18)
                    {


                        Console.WriteLine("You're not an adult yet");
                    }
            }

        }
    }
}
