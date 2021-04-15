﻿using System;

namespace EmployeeWages
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpwage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpwage();
            Console.WriteLine(reliance.toString());
        }
          
    }



}

