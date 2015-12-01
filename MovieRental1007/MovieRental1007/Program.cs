using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MovieRental1007
{
    class Program
    {
        static void Main(string[] args)
        {
           
                var date = DateTime.Today;

                //instanciate new dictionary rental combine date rented to movie
                Dictionary<string, DateTime> rental = new Dictionary<string, DateTime>();


                //inventory 
                List<string> inventory = new List<string>();
                inventory.Add("half baked");
                inventory.Add("the martian");
                inventory.Add("pcu");
                inventory.Add("dr. strangelove");
                inventory.Add("love story");
                inventory.Add("the godfather");
                inventory.Add("alien");
                inventory.Add("aliens");
                inventory.Add("ghostbusters");
                inventory.Add("dazed and confused");

            //hard coded customers
            string[] pat = { "Pat", "216-414.2323" };
            string[] mat = { "Mat", "216-414-2324" };
            string[] sue = { "Sue", "216-414.2326" };
            string[] peg = { "Peg", "216-414.2327" };
            string[] bob = { "Bob", "216-414.2328" };
            string[] tom = { "Tom", "216-414.2329" };
            string[] sam = { "Sam", "216-414.2330" };
            string[] sal = { "Sal", "216-414.2331" };
            string[] don = { "Don", "216-414.2332" };
            string[] deb = { "Deb", "216-414-2333" };

            //to be able to search customers
            List<string[]> customers = new List<string[]>();
                customers.Add(pat);
                customers.Add(mat);
                customers.Add(sue);
                customers.Add(peg);

            //movie check out list list per customer
            List<string> patCheckOut = new List<string>();

            //Check in 
            Console.WriteLine("Would you like to check movies in? Y/N");
            string answer = Console.ReadLine().ToUpper();
            if (answer != "Y" && answer != "N")
            {
                Console.WriteLine("Please enter Y or N");
            }
            if (answer == "Y")
            {
                Console.WriteLine("Enter movie to be checked-in.");

                string returnMovie = Console.ReadLine(); //get movie

                while(returnMovie != null)
                {
                    if (rental.ContainsKey(returnMovie) == true && inventory.Contains(returnMovie) == true) //if movie matches,
                    {

                        rental.Remove(returnMovie);//then delete from rental dictionary 

                        //remove from customer list
                        patCheckOut.Remove(returnMovie);

                        Console.WriteLine("Your movie has been returned.");
                    }
                    else
                    {
                        Console.WriteLine("Movie cannot be returned");
                        break;

                    }

                }
                Console.WriteLine("Total Store Rentals = " + rental.Count);
            }


        

            //check out //remove movie from rental
            Console.WriteLine("Would you like to check movies out? Y/N");
             string answer1 = Console.ReadLine().ToUpper();
            if (answer1 != "Y" && answer != "N")
            {
                Console.WriteLine("Please enter Y or N");
            }
            if (answer1 == "Y")
            {
                Console.WriteLine("Enter movie to be rented");
                string movieSearch = Console.ReadLine().ToLower();

             

               
                    if (inventory.Contains(movieSearch))
                    {
                        rental.Add(movieSearch, date);
                        patCheckOut.Add(movieSearch);
                    }
                    else
                    {
                        Console.WriteLine("Not in inventory. please enter vaild movie");
                       
                    }
                
                    if (rental.ContainsKey(movieSearch) == true && patCheckOut.Contains(movieSearch)== true)
                    {
                        Console.WriteLine("Movie has been rented. Please enter different title");
                        movieSearch = Console.ReadLine();
                    }
                }

                //print current date
                Console.WriteLine("Today's Date: " + DateTime.Today);

                //print due date
                Console.WriteLine("Return Date: " + DateTime.Today.AddDays(5));


                //instanciate new dictionary combine movie list to customer[]
                Dictionary<string[], List<string>> customerRental = new Dictionary<string[], List<string>>();
                customerRental.Add(pat, patCheckOut);

                foreach (KeyValuePair<string[], List<string>> cust in customerRental)
                {

                    //get inside value
                    foreach (List<string> check in customerRental.Values)
                    {
                        //print what's in the list
                        foreach (string c in check)
                        {
                            Console.WriteLine(c);
                        }

                        //get inside the key
                        foreach (string[] customer in customerRental.Keys)
                        {
                            //print the customer data[]
                            foreach (string custData in customer)
                            {
                                Console.WriteLine();
                                Console.Write(custData);

                            }
                        }
                    }

                }


               
                

          
            }

        /*
                //late fee based on dict value

                int lateDays = 0;
                    if (rental.ContainsValue(DateTime.Today))
                    {
                        foreach (var movie in rental)
                        {
                            var startRental = DateTime.Today;
                            var dueDate = DateTime.Today.AddDays(5);
                            while (dueDate >= startRental)
                            {
                                if (dueDate > startRental)
                                {
                                    lateDays++;
                                    Console.WriteLine("late by: " + lateDays + "day");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Not Due Yet");
                                }
                            }
                        }
                    }

            Console.WriteLine("Would you like to run a late report? Y/N");
            string answer2 = Console.ReadLine().ToUpper();
            if(answer2 == "N")
            {
                return;
            }
            else
            {
                
            }


    */


        }
    }
}
