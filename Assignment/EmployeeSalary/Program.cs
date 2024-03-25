
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = AskForInfo("first name");
            employee.LastName = AskForInfo("last name");
            employee.EmployeeNumber = AskForInfo("employee number");
            employee.JobDescription = AskForInfo("job description");
            employee.Department = AskForInfo("department");
            employee.DateOfHire = AskForInfo("date of hire(MM/DD/YYYY)");
            employee.Sales = AskForNumber("sales");
            employee.Salary = AskForNumber("salary");
            Console.WriteLine("\t\tEmployee Info\n");
            Console.WriteLine(employee + "\n\n");

            //with parameter
            Console.WriteLine("Using Single Parameter and use mutator method to set SALARY AND SALES\n");
            Employee employee2 = new Employee("MS123");
            employee2.Salary = 100000;
            employee2.Sales = 100000;
            Console.WriteLine(employee2 + "\n\n");

            Console.WriteLine("Using Three Parameters and use mutator method to set SALARY\n");
            Employee employee3 = new Employee("MS124", "Marvin", "Soro");
            employee3.Salary = 10000;
            Console.WriteLine(employee3 + "\n\n");

            Console.WriteLine("Using five Parameters and use mutator method to set SALES\n");
            Employee employee4 = new Employee("MS125", "Cloud", "Strife", "Developer", "IT");
            employee4.Sales = 100000;
            Console.WriteLine(employee4 + "\n\n");

            Console.WriteLine("Using eight Parameters\n");
            Employee employee5 = new Employee("MS126", "Tifa", "Lockhart", "Comp Tech", "IT", "01/02/1985", 5000, 50000);
            Console.WriteLine(employee5 + "\n\n");

            // Using accessor method
            Console.WriteLine("Access specific information of an instance using accessor method");
            Console.WriteLine("Employee 5 Job Description: [" + employee5.JobDescription + "]");
            Console.WriteLine("Employee 4 First Name: [" + employee4.FirstName + "]");
            Console.WriteLine("Employee 3 Last Name: [" + employee3.LastName + "]");
            Console.WriteLine("Employee 2 Employee Number: [" + employee3.EmployeeNumber + "]");
            Console.WriteLine("Employee Date of Hire: [" + employee.DateOfHire + "]");
            Console.WriteLine();

            Console.ReadKey();
        }

        // This is to ask info
        private static string AskForInfo(string prompt)
        {
            string inputInfo;
            // Employee number will accept alphanumeric except null and whitespace
            if (prompt == "employee number")
            {
                do
                {
                    Console.Write($"Enter {prompt}: ");
                    inputInfo = Console.ReadLine();
                } 
                while (string.IsNullOrWhiteSpace( inputInfo ) );
                return inputInfo;
            }

            // Validate date
            if (prompt == "date of hire(MM/DD/YYYY)")
            {
                do
                {
                    Console.Write($"Enter {prompt}: ");
                    inputInfo = Console.ReadLine();
                }
                while (!ValidateDateFormat(inputInfo));
                return inputInfo;
            }

            // Validate text Input
            do
            {
                Console.Write($"Enter {prompt}: ");
                inputInfo = Console.ReadLine();
            } 
            while (!StringValid( inputInfo ) );
            return inputInfo;
        }

        // This is for salary and sales input
        private static decimal AskForNumber(string prompt)
        {
            string inputNumber;
            decimal number;
            do
            {
                Console.Write($"Enter {prompt}: ");
                inputNumber = Console.ReadLine();
            } while (!decimal.TryParse(inputNumber, out number));

            return number;
        }

        // Date validation
        private static bool ValidateDateFormat(string date)
        {
            // Define the regex pattern for the "MM/DD/YYYY" format
            string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|1\d|2\d|3[01])/\d{4}$";

            if (Regex.IsMatch(date, pattern))
            {
                return true;
            }
            Console.WriteLine("Invalid date.");
            return false;
        }

        // String validation
        private static bool StringValid(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || Regex.IsMatch(input, @"\d"))
            {
                Console.WriteLine("Invalid input.");
                return false;
            }
            return true;
        }
    }
}
