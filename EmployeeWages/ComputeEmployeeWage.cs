using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        /// <summary>
        /// this method will compute employee wage salary
        /// </summary>
        public void computeEmpwage()
        {
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
            totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total employee wage for company : " + company + " is : " + totalEmpWage);
        }

        /// <summary>
        /// toString() methos is read object to string formate.
        /// </summary>
        /// <returns></returns>
        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is :" + this.totalEmpWage;
        }
    }
}

