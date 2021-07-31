using System;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiation object of class 1 named obj 1//
            Class1 obj1 = new Class1();
            //display a message, read user input into int//
            Console.WriteLine(" enter a number");
            int y = Convert.ToInt32(Console.ReadLine());
            //calls the method1 method through obj1//
            obj1.Method1(y);
            int num;
            //calls the method2 method through obj1//
            obj1.Method2(out num);
            Console.WriteLine(num);
            string text = " a value";
            //calls overloaded version of method1//
            obj1.Method1(text);
            Class2.Method1();

            Console.ReadLine();




        }
    }
}
