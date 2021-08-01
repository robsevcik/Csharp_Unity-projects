using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
    public abstract class Person
    {
        //properties//
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public abstract void SayName();


    }
}

