using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieRental
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Today;
            var startRental = DateTime.Today;
            var dueDate = DateTime.Today.AddDays(5);

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
            string[] pat = { "Pat", "216-414-2323" };
            string[] mat = { "Mat", "216-414-2324" };
            string[] sue = { "Sue", "216-414-2326" };
            string[] peg = { "Peg", "216-414-2327" };
            //to be able to search customers
            List<string[]> customers = new List<string[]>();
            customers.Add(pat);
            customers.Add(mat);
            customers.Add(sue);
            customers.Add(peg);
            //inventoryRented
            List<string> inventoryRented = new List<string>();
            inventoryRented.Add("stand by me");
            inventoryRented.Add("gremlins");
            inventoryRented.Add("seven samurai");
            inventoryRented.Add("serenity");
            inventoryRented.Add("star wars");
            inventoryRented.Add("citizen kane");

            //Overdue inventory
            List<string> inventoryOverdue = new List<string>();
            inventoryOverdue.Add("star wars");
            inventoryOverdue.Add("citizen kane");

            //Customers with overdue inventory
            List<string> customersOverdue = new List<string>();
            customersOverdue.Add("Sue, 216-878-1234");
            customersOverdue.Add("Ben, 440-333-6789");
            var overdue = String.Join(", ", inventoryOverdue.ToArray());
            var overdueTwo = String.Join(", ", customersOverdue.ToArray());

            //Check in 
            Console.WriteLine("Please make selection 1, 2, or 3");
            Console.WriteLine("1 - Return a movie");
            Console.WriteLine("2 - Rent a movie");
            Console.WriteLine("3 - Obtain overdue account and contact information");
            int answer = int.Parse(Console.ReadLine());
            int result = answer;
            switch (result)
            {
                case 1:
                    Console.WriteLine("Enter movie title to be returned.");
                    string title = Console.ReadLine().ToLower();
                    while (title != null)
                    {
                        if (inventoryOverdue.Contains(title))
                        {
                            Console.WriteLine("Charge $5 Late Fee. Movie has been returned.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Movie has been returned.");
                            break;
                        }

                    }
                    break;

                case 2:
                    Console.WriteLine("Enter movie title to be rented.");
                    string titleTwo = Console.ReadLine().ToLower();

                    {
                        if (inventory != null)
                        {
                            Console.WriteLine("Movie has been rented. Thanks for your business.");
                            Console.WriteLine("Movie Due Date is " + dueDate);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Overdue movies: " + overdue);
                    Console.WriteLine("Overdue customer contact info: " + overdueTwo);
                    break;
            }
        }

    }
}
