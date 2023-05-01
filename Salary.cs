using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace managent
{
    class Salary
    {
        public class SalaryCalculator
        {
            public static void Main1()
            {
                int weeklyHours;
                int weeksPerYear;
                decimal hourlyPay;
                decimal monthlySalary;
                decimal yearlySalary;
                const decimal TAX_RATE = 0.20m; //tax applied to income

                //welcome user and prompt to assign variables
                Console.WriteLine("Welcome to Salary Calculator!");
                Console.WriteLine("\nPlease enter the following information:");
                Console.Write("Hourly pay: $");
                hourlyPay = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Hours worked each week: ");
                weeklyHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Weeks worked each year: ");
                weeksPerYear = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nThank You.");

                //calculate salaries
                monthlySalary = (hourlyPay * (decimal)weeklyHours) * 4m * (1 - TAX_RATE);
                yearlySalary = (hourlyPay * (decimal)weeklyHours) * (decimal)weeksPerYear * (1 - TAX_RATE);

                //displays salaries
                Console.WriteLine("Monthly salary: {0:C} \nYearly salary: {1:C}", monthlySalary, yearlySalary);
            }
        }
    }
}
