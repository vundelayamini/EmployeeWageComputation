using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welome to Employee Wage Program");
            EmpWage.computeEmpWage("DMart", 20, 2, 10);
            EmpWage.computeEmpWage("Reliance", 10, 4, 20);
        }
    }
}

  