using System;

namespace Abstract_Class_Submission_Assignment
{
    public class Employee : Persons
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }


    }
}
