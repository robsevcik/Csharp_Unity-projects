using System;

namespace Abstract_Class_Submission_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            employee.SayName();

            IQuittable obj = new Employee();

            obj.Quit();


            Console.ReadLine();
        }

    }
}
