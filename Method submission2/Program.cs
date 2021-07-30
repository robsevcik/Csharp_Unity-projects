using System;

namespace Method_submission2
{
    class Program
    {
        static void Main(string[] args)
        {
            optional1 optional1 = new optional1();

            Console.WriteLine("input a number");
            int v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input a second number or nothing");
           string y = Console.ReadLine();

             if (y == "")
            {
                optional1.AddNumbers(v);


            }
             else
            {
                int x = Convert.ToInt32(y);
                optional1.AddNumbers(x, v);
               
            }
        }
    }
}
