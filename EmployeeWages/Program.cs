using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int present = 1;

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine("random value " + empCheck);
            if (empCheck == present)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
            Console.ReadKey();
        }
    }
}
