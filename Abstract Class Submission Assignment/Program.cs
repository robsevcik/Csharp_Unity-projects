using System;

namespace Abstract_Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employee obj1 = new Employee();

            obj1.Firstname = "Sample";
            obj1.Lastname = "Student";

            obj1.SayName();
            //create an object with polymorphism//
            IQuittable obj2 = new Employee();

            // call a method on the object//
            obj2.Quit();
        }
    }
}