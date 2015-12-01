using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //add this!!

namespace MvcDemo.Models
{
    public class MovieDb
    {
        public int ID { get; set; } //creating properties here
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }

    }
    public class MovieDbContext : DbContext
    {
        public DbSet<MovieDb> Movies { get; set; } //this is a special type of data collection of MovieDb Objects

        
    }
}