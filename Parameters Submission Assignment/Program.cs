using System;
using System.Collections.Generic;

namespace Parameters_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> obj1 = new Employee<string>();

          

            obj1.Things = new List<string> { "cat", "dog", "boy" };

            Employee<int> obj2 = new Employee<int>();

            obj2.Things = new List<int> { 5, 3, 523 };

            //loop through list with a for loop//
            foreach (string item in obj1.Things)
            {
                Console.WriteLine(item);
            }
            foreach (int item in obj2.Things) 
            {
                Console.WriteLine(item);
            }
            // foreach loop directly accesses items in array, use to print array//
        }
    }

}
