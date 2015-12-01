using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1021
{
    public class Collar
    {
        private int size;

        public Collar()
        {

        }
    }


    public class Dog
    {
        private string name;
        private double length;
        private Collar collar;
        private int age = 2;

        public int GetAge()
        {
            return this.age;
        }

        static void Main()
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog's age is: " + dog.GetAge());

            
        }

        int Add(int num1, int num2) //declare method class without parameter
        {
            int result = num1 + num2;
            return result;
        }


        public Dog(string dogName, int dogAge, double dogLength)
        {
            name = dogName;
            age = dogAge;
            length = dogLength;
            collar = new Collar();
        }




        public Dog()
        {
            this.name = "Axl";
            this.age = 1;
            this.length = 0.3;
            this.collar = new Collar();
        }

        public Dog(string name)
        {
            this.name = name;
            this.age = 1;
            this.length = 0.3;
            this.collar = new Collar();
        }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.length = 0.3;
            this.collar = new Collar();
        }
    }

  




}
