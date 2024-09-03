using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //Ask User to Enter the Employee Details
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("----------------------");
            Console.Print('Enter Employee ID (3 digits) : ');
            int employeeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name          : ");

            string name = Console.ReadLine();
            Console.Write("Enter Employee Annual Salary : $")
            string salary = Console.ReadLine();
            Console.Write("Enter Employee Department    : ");
            string department = Console.ReadLine();

            //Display the Entered Employee Details
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Your Entered Employee Details");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Employee ID Is         : {employeeID}");
            Console.WriteLine($"Employee Name Is       : {name}");
            Console.WriteLine($"Employee Salary Is     : ${Salary}");
            Console.WriteLine($"Employee Department Is : {department}");
            ReadLine();

        }
    }


