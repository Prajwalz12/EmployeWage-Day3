using System;

namespace EmpWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            int empRatePerHr = 20;
            int FullTimeHr = 8;
            int ParttimeHr = 4;
            int totalSalary = 0;
            int WorkingDays = 20;
            int salary;

            for (int day = 1; day <= WorkingDays; day++)
            {
                int rand = new Random().Next(3);
            if (rand == 0)
                {
                    Console.WriteLine("is full time");
                    salary = FullTimeHr * empRatePerHr;
                }
                else if (rand == 1)
                {
                    Console.WriteLine("is Part time");
                    salary = ParttimeHr * empRatePerHr;
                }
                else
                {
                    salary = 0;
                }
                Console.WriteLine($"Total Salary : {salary}");
                }
            }

        }
    }


