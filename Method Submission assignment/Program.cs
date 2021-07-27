using System;

namespace Method_Submission_assignment
{
    class Program
    {
        private static int numtwo;

        static void Main()
        {
            Arithmatic math = new();

            Console.WriteLine("enter a number to multiply by");
            int numone = Convert.ToInt32(Console.ReadLine());

            int d = math.MyMethod(numone);
            Console.WriteLine("total first number multiplyed by 5 = " + d);

           // Console.WriteLine("enter a second number, or it will be zero");
           //string stringNumTwo = Console.ReadLine();

           // if (stringNumTwo == "")
           // {

           //     Console.WriteLine("You must enter a number please.");
           // }
           // else
           // {
                int c = math.MyMethod1(numone, numtwo);
                Console.WriteLine("total of number plus 5 = " + c);

            int a = math.MyMethod2(numone);
            Console.WriteLine("number divided by 2 = " + a);

            Console.WriteLine("Thank you for playing");

            Console.ReadLine();
        }
        
    }
}
