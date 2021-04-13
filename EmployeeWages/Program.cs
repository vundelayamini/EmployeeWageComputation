using System;

namespace EmployeeWages
{
    class Program
    {
        //constants
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 10;

        public static int ComputeEmpWage()
        {
            //local variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            //inbuilt class
            while (totalEmpHrs < MAX_WORKING_HRS && totalWorkingDays <= MAX_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                // computation
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
               int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }




}

