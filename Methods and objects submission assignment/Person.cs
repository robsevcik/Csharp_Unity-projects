using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_objects_submission_assignment
{
    class Person
    {// properties of the class//
    public string Firstname { get; set; }
    public string Lastname { get; set; }

        public void SayName()
        {
        
            Console.WriteLine(Firstname + Lastname);
        }
    }
}
