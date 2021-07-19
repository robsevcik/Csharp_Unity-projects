using System;

namespace income_comparrison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Hours per week?");
            int hourly1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
   
            Console.WriteLine("Hours per week");
            int hourly2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Anual salary of person 1");
            int salary1 = rate1 * hourly1;
            int salary2 = rate2 * hourly2;
            int Anualsalary1 = salary1 * 52;
            int Anualsalary2 = salary2 * 52;
            Console.WriteLine(Anualsalary1);
            Console.WriteLine("Anual salary of person 2");
            Console.WriteLine(Anualsalary2);
            Console.WriteLine("Does Person 1 make more money than person2?");
            bool totalsalary = Anualsalary1 > Anualsalary2;
            Console.WriteLine(totalsalary);
            Console.ReadLine();



        }
    }
}

