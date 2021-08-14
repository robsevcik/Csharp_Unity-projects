using ImTools;
using System;
using System.IO;



namespace Date_Time_submission_assignment
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Enter a Number please");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime d1 = DateTime.Now;
            DateTime d2 = d1.AddHours(number);
            Console.WriteLine("initial DateTime = {0:dd} {0:y}, {0:t}", d1);
            Console.WriteLine("\nNew DateTime (After adding hours) = {0:dd} {0:y}, {0:t} ", d2);
            Console.ReadLine();
        }

        


    }
    
}
