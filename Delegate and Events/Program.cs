using System;
using System.Collections.Generic;

namespace Delegate_and_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee() { ID = 1, Name = "Alshaimaa", Salary = 6000 };
            Employee e2 = new Employee() { ID = 2, Name = "Esraa", Salary = 6000 };
            Employee e3 = new Employee() { ID = 3, Name = "Asmaa", Salary = 2000 };

            List<Employee> emlist = new List<Employee>();
            emlist.Add(e1);
            emlist.Add(e2);
            emlist.Add(e3);

            Company company = new Company() { Name = "MMM", Budget = 20000, employees = emlist };

            Console.WriteLine("The employee is " + e1);
            Console.WriteLine("The Company is " + company);
            //Employee.DecreaseBudget += company.decreaseBudget;
            Console.WriteLine("*****************************************");

            e1.DecreaseBudget += company.decreaseBudget;
            e1.IncreaseSalary(2000);
            e1.IncreaseSalary(2000);

            Console.WriteLine("The employee is " + e1);
            Console.WriteLine("The Company is " + company);
            Console.WriteLine("*****************************************");

            e2.DecreaseBudget += company.decreaseBudget;
            e2.IncreaseSalary(2000);

            //e2.IncreaseSalary(2000,company);
            //e2.IncreaseSalary(2000, company);
            //e2.IncreaseSalary(2000, company);
            Console.WriteLine("The employee is " + e2);
            Console.WriteLine("The Company is " + company);
            Console.WriteLine("*********************Filteration********************");


            #region Filteration
            Predicate<float> predicate = sal => sal > 5000;


            List<Employee> empFilter = company.FilterEmployees(predicate);

            foreach (Employee emp in empFilter)
            {
                Console.WriteLine(emp);
            }

            #endregion

        }
    }
}
