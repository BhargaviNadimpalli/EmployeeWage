using System;

namespace Employee_Wage_Using_Oops_Concepts
{ 
class Program
    {
        static void Main(string[] args)
            {
                EmployeeWage employee = new EmployeeWage();
            
               employee.AddCompanyEmpWage("TCS", 20, 22, 121);
                employee.AddCompanyEmpWage("Wipro", 33, 24, 134);
                employee.ComputeEmpWage();
             }
        }
}
