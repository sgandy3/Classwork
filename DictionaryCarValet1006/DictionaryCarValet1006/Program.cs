using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCarValet1006
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> carValet = new Dictionary<string, string>();
            carValet.Add("Gates", "Mercedes");
            carValet.Add("Wilson", "Ford");
            carValet.Add("Gottschalk", "Infinity");
            carValet.Add("McDowell", "Kia");
            carValet.Add("France", "Toyota");
            carValet.Add("Martin", "Mazda");
            carValet.Add("Lowe", "Buick");
            carValet.Add("Sheilds", "BMW");
            carValet.Add("Howard", "Cadillac");
            carValet.Add("Harvey", "Chrysler");

            foreach(KeyValuePair<string,string> car in carValet)
            {
                Console.WriteLine(car);
            }
        }
    }
}
