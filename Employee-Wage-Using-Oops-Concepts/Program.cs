using System;

namespace Employee_Wage_Using_Oops_Concepts
{

    
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeClass obj = new EmployeeClass();
            obj.CompanyEmpWage("Wipro", 57, 27, 100);
            obj.CompanyEmpWage("TCS", 77, 30, 150);
        }
    }
}
