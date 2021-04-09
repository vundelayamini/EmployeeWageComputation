using System;

namespace EmployeeWages
{
    class Program
    {
        //constants
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        public const int WORKING_HRS = 20;

        static void main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            //inbuilt class
            Random random = new Random();
            while (hrs < MAX_WORKING_HRS && workingDays<= MAX_WORKING_DAYS)
            {
                workingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;

                    case PART_TIME:
                        empHrs = 4;
                        break;

                    case default:
                        empHrs = 0;
                        break;
                }

                //computation
                empWage = EMP_RATE_PER_HR * empHrs;
                hrs += empHrs;
                Console.WriteLine("per day employee wage" + empWage);
                totalEmpWage += empWage;//totalEmpWage = totalEmpWage + empWage
            }
            Console.WriteLine("Employee wage for  " + workingdays + "days" totalempWage);
            Console.WriteLine("working hrs" + hrs);
            Console.Read();
        }

        
    }
}
