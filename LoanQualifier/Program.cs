using System;

namespace LoanQualifier
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Edwin Inga
              NMAD-180
              Professor Berrios
              Practicing Nested If Statements
              */

            //setting variables
            int salary, jobYears;

            //asking user to input their salary
            Console.Write("Enter your annual salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            //making if statement in the case that user's job pays more than 40k
            if (salary >= 40000)
            {
                //asks user another question after meeting the minimum salary requirement
                Console.Write("\nHow many years do you have on the job? ");
                jobYears = Convert.ToInt32(Console.ReadLine());

                //telling user that their job experience and salary qualifies them for the loan
                if (jobYears >= 2)
                {
                    Console.WriteLine("\nYou qualify for the loan");
                }
                // telling user that their salary is okay but they don't have enough job experience for a loan
                else if (jobYears < 2)
                {
                    Console.WriteLine("\nMinimum years at job not met");
                }
            }
            // if user does not meet minimum salary requirement of 40k, user is told they don't qualify for loan
            else if (salary < 40000)
            {
                Console.WriteLine("\nMinimum salary requirements not met");
            }
            Console.WriteLine("\nProgram end...exiting");
        }
    }
}
