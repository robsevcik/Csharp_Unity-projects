using System;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee();

            obj1.ID = (5);
            obj2.ID = (6);

            Console.WriteLine(obj1.ID == obj2.ID);
            Console.ReadLine();
        }

        
        

    }
}
