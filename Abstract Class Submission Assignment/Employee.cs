﻿using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Submission_Assignment
{
   public class Employee: Persons
    {
        public override void SayName()
        {
           Console.WriteLine(firstName + lastName);
        }

        
    }
}
