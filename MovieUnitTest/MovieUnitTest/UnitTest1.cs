using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovieUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //get customer info, get inventory, save data, console writeline
            MovieUnitTest.Customer_Information;
            MovieUnitTest.Inventory;

        }
    }

    [TestClass]
    public class Inventory
    {
        public void Movie_CheckOut()
        {
        }

        public void Movie_CheckIn()
        {
        }
    }

    [TestClass]
    public class Customer_Information
    {
        public void Customer_Contact()
        {

        }
    }

    [TestClass]
    public class Customer_Checkout_List
    {
    }


    [TestClass]
    public class Customers_With_LateFee
    {
    }

}
