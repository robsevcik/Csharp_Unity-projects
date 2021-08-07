using System;

namespace Parsing_Enums_Submission_Assignment
{
    public class Program
    {

        public static void Main(string[] args)
        { 

            bool isvalid = false;

            while (isvalid == false){ 
                try
                {
                    Console.WriteLine("enter current day of the week");

                    string Dayinput = Console.ReadLine();
                    Day day = (Day)Enum.Parse(typeof(Day), Dayinput);
                    Console.WriteLine("have a nice " + day);

                    Console.ReadLine();
                    isvalid = true;


                }
               catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                    Console.ReadLine();

                }

            }
           
        }
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

        }


        



    }
}









//    foreach (string val in Daylist) {
//Day day;
//if (Enum.TryParse(val, true, out day))
//    if (Enum.IsDefined(typeof(Day), day) | vehicle.ToString()
//        .Contains(","))
//        Console.WriteLine
    //    string name = null;
    //    if (string.IsNullOrEmpty(name))
    //            {
    //        throw new SevcikCustomException("please enter a day of the week");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Day: " + name);

    //    }
    //    Console.ReadLine();
    //        }
    //public class SevcikCustomException: Exception { 
    //    public SevcikCustomException()
    //{

    //}
    //public SevcikCustomException(string message) : base(message)
    //    {

    //}
    //public SevcikCustomException(string message,Exception innerexception) : base(message, innerexception)
    //    {

    //}

 








