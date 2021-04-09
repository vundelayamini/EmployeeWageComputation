using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int PRESENT = 1;
            int EMP_RATE_PER_HR = 20;

            //local variables
            int empHrs = 0;
            int empWage = 0;

            //inbuilt class
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            Console.WriteLine("random value " + empCheck);
            //selection statements
            if (empCheck == PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empWage = 0;
            }
            empWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("Employee wage per day " + empWage);
            Console.ReadKey();
        }
    }
}
