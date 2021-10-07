using System;

namespace EmpWage1
{
    class switchcase
    {
        static void Main(string[] args)
        {
            int FullTimeHr = 8;
            int PartTimeHr = 4;
            int emprateperHr = 20;
            int check = new Random().Next(2);
            switch (check)
            {
                case 0:
                    Console.WriteLine($"Part Time Salary is : {emprateperHr * PartTimeHr}");
                    break;
                case 1:
                    Console.WriteLine($"Full Time Salary is : {emprateperHr * FullTimeHr}");
                    break;
            }



        }
    }
}



