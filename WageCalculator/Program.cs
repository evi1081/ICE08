using System;

namespace WageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Edwin Inga
              NMAD-180
              Professor Berrios
              Practicing Nested If Statements
              1/30/2021
              */

            //setting variables
            int hoursWorked;
            double hourlyRate, grossPay;
            const int BASE_HOURS = 40;
            const double OT_MULTIPLIER = 1.5;

            // Asking user for their hourly rate
            Console.Write("Please enter your hourly rate: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            // Asking user their amount of hours worked
            Console.Write("Please enter the number of hours worked: ");
            hoursWorked = Convert.ToInt32(Console.ReadLine());

            // calculating whether or not user works more hours than expected based off of the base hours, and if they do the Overtime multiplier is added into the wage formula
            if (hoursWorked > BASE_HOURS)
            {
                grossPay = ((hourlyRate * OT_MULTIPLIER) * hoursWorked);
            }

            // if user does not work overtime, normal formula is used to calculate wage
            else
            {
                grossPay = hoursWorked * hourlyRate;
            }

            Console.WriteLine("Your Weekly Gross Pay: $" + grossPay);
        }
    }
}
