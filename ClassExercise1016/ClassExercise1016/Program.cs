using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise1016
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentInfo = new Student();
            Console.WriteLine(studentInfo.FullName);
            Console.WriteLine(studentInfo.Course);
            Console.WriteLine(studentInfo.Subject);
            Console.WriteLine(studentInfo.University);
            Console.WriteLine(studentInfo.PhoneNumber);

           
        }
    }

    //Define a class Student which contains the following information about a student: full name, course, subject, university, email, and phone number.

    //Declare 5 constructors for the class Student which have different parameters.

    //Create a method that prints out a student’s name, email and phone number.Call it from main.

    //Adjust the get on the property FullName so that when accessed from your main method, it is printed in all caps.




    class Student
    {
        public string fullName;
        public string course;
        public string subject;
        public string university;
        public string email;
        public string phoneNumber;

    

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
            }
        }



        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }


        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }



        public string University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }



        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }




        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public Student()
        {
            this.fullName = "Will Smith";
            this.course = "101";
            this.subject = "Math";
            this.university = "Iowa";
            this.email = "w.smith@iowa.edu";
            this.phoneNumber = "216-123-4567";
        }

        // constructors
        public Student(string fullName, string phoneNumber)
        {
            this.fullName = fullName;
            this.phoneNumber = phoneNumber; 
        }

        public Student(string course, string subject)
        {
            this.course = course;
            this.subject = subject;
        }



    }
}
