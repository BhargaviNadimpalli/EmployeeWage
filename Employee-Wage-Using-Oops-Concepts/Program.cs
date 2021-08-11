using System;

namespace EmployeeWageComputation
{


    class Program
    {
        static void Main(string[] args)
        {
            Employee_Wage_Using_Oops_Concepts.EmployeeClass obj = new Employee_Wage_Using_Oops_Concepts.EmployeeClass();
            obj.CompanyEmpWage("Wipro", 57, 27, 100);
            obj.CompanyEmpWage("TCS", 77, 30, 150);
           
        }

    }

}