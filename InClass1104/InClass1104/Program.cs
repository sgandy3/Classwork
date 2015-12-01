using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1104
{
    class Program
    {
            /*Create a new Console App. In Main method:
                Declare an array of ints. 
                Assign the array to 7 different integer values.
                Create a query expression that will filter out only those ints from the array having a number greater than 6.
                Execute the query and loop through values to display them, one per line. */

        static void Main(string[] args)
        {
            int[] nums = { 2, 45, 1, 89, 5, 10, 90 };

            IEnumerable<int> numsQuery = from n in nums where n > 6 select n;
            

            foreach(int i in numsQuery)
            {
                Console.WriteLine(i);
            }


            
            //Obtaining a Data Source
            //queryAllCustomers is an IEnumerable<Customer>
            var queryAllCustomers = from cust in customers
                                    select cust;

            //Filtering
            var queryLondonCustomers = from cust in customers
                                       where cust.City == "London"
                                       select cust;
            //Ordering
            var queryLondonCustomers3 =
                from cust in customers
                where cust.City == "London"
                orderby cust.Name ascending
                select cust;

            var queryLondonCustomers4 =
                from cust in customers
                where cust.City == "London"
                orderby cust.Name descending
                select cust;

            var queryCustomersByCity =
                from cust in customers
                group cust by cust.City;


            //Grouping
            //customerGroup is an IGrouping<string,Customer> //Igrouping-represents a collection of objects that have a common key
            foreach (var customerGroup.Key) ;
            foreach(Customer customer in customerGroup)
            {
                Console.WriteLine(" {0}", customer.Name);
            }

            //Joining

            var innerJoinQuery =
                from cust in customers
                join dist in distributors on cust.City equals dist.City
                select new { CustomerName = cust.Name, DistributorName = dist.Name };


        }
    }
}
