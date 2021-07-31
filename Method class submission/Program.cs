using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_class_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("enter a number");
            int numone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter aother number");
            int numtwo = Convert.ToInt32(Console.ReadLine());


             Class1.Method(numone, numtwo);

            Class1.Method(parameter1: numone, parameter2: numtwo);
        }
    }
}
