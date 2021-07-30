using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_submission2
{
    class optional1
    {
        public static void AddNumbers(int firstnumber, int secondnumber = 5)
        {

            int result = firstnumber + secondnumber;

            Console.WriteLine(result);
        }

    }
}
