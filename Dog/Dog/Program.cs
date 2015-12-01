using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {

        static void Main()
        {
            Dog myDog = new Dog(); //instanciate new object
            Console.WriteLine(myDog.Name);
            myDog.Woof(); //called method Woof from Dog
            Dog mySecondDog = new Dog("Tricycle","Dotted");

            mySecondDog.Name = "Oreo";
            mySecondDog.Woof();

            mySecondDog.Wag();
        }
    }

    class Dog
    {
        private string name; //access modifier, data type, variable
        private string color;

        public string Name
        {
            get
            {
                return this.name; //get field name using keyword this
            }
            set //assigns field to value
            {
                this.name = value;
            }

        }
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
               this.color = value; //set
            }
        }

        public Dog()
        {
            this.color = "maroon"; //default value
            this.name = "Fido"; //default value
        }

        public Dog(string someName,string someColor) //2 parameters
        {
            this.name = someName; 
            this.color = someColor;
        }

        public void Woof()
        {
            Console.WriteLine("The dog named {0}, who is {1} in color, said \"woof\"", name,color);

            Console.WriteLine("The dog named "+ name + " who is "+color+" in color, said \"woof\"");
        }

        public void Wag()
        {
            Console.WriteLine("The dog named " + name +", is wagging its tail.");
        }
    }
}
