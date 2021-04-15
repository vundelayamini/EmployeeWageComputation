using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWage
    {

        //Constants declarations
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        
        // Calculate employee wage for multiple companies using method 
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //Variables declarations
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days is : " + totalWorkingDays + " " + "Employee Hours is :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total employee wage for companies : " + company + " is :" + totalEmpWage);
            return totalEmpWage;
        }
    }
}
    

