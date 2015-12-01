using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            Console.WriteLine("Select the menu number");

            switch (caseSwitch)
            {
                
                case 1:
                    Console.WriteLine("Checkout = 1");
                    
                    Checkout();
                    break;
                case 2:
                    Console.WriteLine("Return = 2");
                    MovieReturn();
                    break;
                case 3:
                    Console.WriteLine("Report = 3");
                    Report();
                    break;
    
            }
        }

        public void Inventory()
        {
            List<string> Movies = new List<string>();
            Movies.Add("Beloved");
            Movies.Add("Bad Boys");    
        }
        public static void CustomerData()
        {
            Dictionary<string, string> customer = new Dictionary<string, string>();
            customer.Add("bob barker", "555-555-5555");
        }


        private void Checkout(Dictionary<string, string>customer, List<string>Movies)
        {
            //get movie, remove movie from inventory
            //get customer
            //add timestamp
            //console.WriteLine(movie,customer,timestamp)
            //return movie, timestamp, customer
           
        }

        public void MovieReturn()
        {   
             //if movie is late, add late fee
             //add movie to inventory
             //delete customer name from movie

        }

        public void Report()
        {
            //check movie timestamp
            //if timestamp is past x days then, add late fee, show amount days late
            //display customer information
        }
    }

   
}
