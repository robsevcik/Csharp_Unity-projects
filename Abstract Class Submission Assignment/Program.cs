using System;

namespace Abstract_Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.firstName = "Sample";
            employee.lastName = "Student";

            Employee.SayName();
        }
    }
}
