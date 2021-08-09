using System;

namespace Lambda_Submission_Assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
          

            Employee emp1 = new Employee();
            {
                emp1.FirstName = "Joe";
                emp1.LastName = "Swanson";
                emp1.ID = 001;
            }

            Employee emp2 = new Employee();
            {
                emp2.FirstName = "Joe";
                emp2.LastName = "Strummer";
                emp2.ID = 002;
            }

            Employee emp3 = new Employee();
            {
                emp3.FirstName = "Joe";
                emp3.LastName = "Johnson";
                emp3.ID = 003;
            }

            Employee emp4 = new Employee();
            {
                emp4.FirstName = "Ian";
                emp4.LastName = "Curtis";
                emp4.ID = 004;
            }

            Employee emp5 = new Employee();
            {
                emp5.FirstName = "Ian";
                emp5.LastName = "Mcay";
                emp5.ID = 005;
            }

            Employee emp6 = new Employee();
            {
                emp6.FirstName = "Nicky";
                emp6.LastName = "Six";
                emp6.ID = 006;
            }

            Employee emp7 = new Employee();
            {
                emp7.FirstName = "Nick";
                emp7.LastName = "Mars";
                emp7.ID = 007;
            }

            Employee emp8 = new Employee();
            {
                emp8.FirstName = "Tommy";
                emp8.LastName = "Lee";
                emp8.ID 008;
            }

            Employee emp9 = new Employee();
            {
                emp9.FirstName = "Vince";
                emp9.LastName = "Neil";
                emp9.ID = 009;
            }

            Employee emp10 = new Employee();
            {
                emp10.FirstName = "Brandon";
                emp10.LastName = "Lee";
                emp10.ID = 010;
            }



            List<string> employeelist = new List<string>();

            employeelist.Add("Joe Swanson");
            employeelist.Add("Joe Stummer");
            employeelist.Add("Joe Johnson");
            employeelist.Add("Ian Curtis");
            employeelist.Add("Ian Mcay");
            employeelist.Add("Nicky Six");
            employeelist.Add("Nick Mars");
            employeelist.Add("Tommy Lee");
            employeelist.Add("Vince Neil");
            employeelist.Add("Brandon Lee");


            int counter = 0;
            foreach (string Joe in Employee)
            {
                if (Employee.FirstName == FirstName.Joe)
                {
                    counter++;

                }

            }
            Console.WriteLine(counter);

            string count = Employee.count(x => x.Employee == firstName.Joe);

            List<int> employeeList = new List<int>() = { employeeList.where(x => Id > 5).ToList};
            Console.ReadLine();
        }

    }
}
