using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HR = 20;

            //local variables
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            Console.WriteLine("random value " + empCheck);
            //selection statements
            if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empCheck==PART_TIME)
            {
                empWage = 4;
            }
            else
            {
                empHrs = 0;
            }
            //computation
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage per day " + empWage);
            Console.ReadKey();
        }
    }
}
