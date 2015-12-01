using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Movie
    {
        private string title;
        private string director;

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public string Director
        {
            get
            {
                return this.director;
            }
            set
            {
                this.director = value;
            }
        }
        
        public static string GetMovie(string title,string director)
        {
            title = "";
            director = "";

        }

    }//movie

    class customer
    {
        private string name;
        private string phone;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }
    }//customer

    class RentOut
    {
        public string Checkout()
        {
            
        }
    }//RentOut




}//namespace
