using System;

namespace EmpWage1
{
    class Program
    {
        static int Main(string[] args)
        {
            int isPartTime = 1;
            int isFullTime = 2;
            int emprateperHr = 20;
            Random random = new Random();

            int check = random.Next(0, 3);

            if (check == isPartTime)
            {
                Console.WriteLine("is part time");
                int empHr=4 ;
                int salary;
                return salary = (emprateperHr * empHr);

            }
                else if (check == isFullTime)
            {
                Console.WriteLine("is full time");
                int empHr=8;
                int salary;
                return salary = (emprateperHr * empHr);

            }
              else
            {
                int emprHr;
                return emprHr = 0;

            }

                
        }
    }
}


