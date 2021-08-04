using System;

namespace Abstract_Class_Submission_Assignment
{
    public class Employee : Persons, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Its working");
        }

        
    }
}
