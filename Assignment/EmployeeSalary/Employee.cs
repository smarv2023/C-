using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    internal class Employee
    {
        // Encapsulate all variables
        private const double TOTAL_SALE_COMMISSION = 0.07;
        private const double FEDERAL_TAX = 0.18;
        private const double RETIREMENT_CONTRIBUTION = 0.10;
        private const double SOCIAL_SECURITY_TAX = 0.06;

        private string employeeNumber;
        private string firstName;
        private string lastName;
        private string jobDescription;
        private string department;
        private string dateOfHire;
        private decimal sales;
        private decimal salary;


        // Overloaded Constructor
        public Employee() { }

        public Employee(string employeeNumber)
        {
            this.employeeNumber = employeeNumber;
        }

        public Employee(string employeeNumber, string firstName)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
        }

        public Employee(string employeeNumber, string firstName, string lastName)
        {
            this.employeeNumber= employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee(string employeeNumber, string firstName, string lastName, string jobDescription)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobDescription = jobDescription;
        }

        public Employee(string employeeNumber, string firstName, string lastName, string jobDescription, string department)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobDescription = jobDescription;
            this.department = department;
        }

        public Employee(string employeeNumber, string firstName, string lastName, string jobDescription, string department, string dateOfHire)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobDescription = jobDescription;
            this.department = department;
            this.dateOfHire = dateOfHire;
        }

        public Employee(string employeeNumber, string firstName, string lastName, string jobDescription, string department, string dateOfHire, decimal salary)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobDescription = jobDescription;
            this.department = department;
            this.dateOfHire = dateOfHire;
            this.salary = salary;
        }

        public Employee(string employeeNumber, string firstName, string lastName, string jobDescription, string department, string dateOfHire, decimal sales, decimal salary)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.jobDescription = jobDescription;
            this.department = department;
            this.dateOfHire = dateOfHire;
            this.sales = sales;
            this.salary = salary;
        }

        // getter and setter
        public string EmployeeNumber
        {
            get { return employeeNumber; } 
            set { employeeNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public decimal Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        /// <summary>
        /// Calculate the sales commission based on the total sales amount.
        /// Calculate the Retirement Contribution based on the total Gross income.
        /// Calculate the Social Security Tax based on the total Gross income.
        /// </summary>
        /// <returns>decimal value</returns>
        private decimal SalesCommision()
        {
            return Sales * (decimal)TOTAL_SALE_COMMISSION;
        }

        private decimal RetirementContribution()
        {
            return (SalesCommision() + Salary) * (decimal)RETIREMENT_CONTRIBUTION;
        }

        private decimal SocialSecurityTax()
        {
            return (SalesCommision() + Salary) * (decimal)SOCIAL_SECURITY_TAX;
        }

        /**
         * Retirement Contribution Rate: 10% of Gross
         * Social Security Tax Rate: 6% of Gross
         * Federal Tax Rate: 18% after the deduction of (Retirement Contribution and SocialSecurity Tax)
         */
        private decimal Gst()
        {
            return (SalesCommision() + Salary - SocialSecurityTax() - RetirementContribution()) * (decimal)FEDERAL_TAX;
        }

        // ToString to show all data.
        public override string ToString()
        {
            return $"Employee Full Name:\t\t{FirstName} {LastName}\n" +
                $"Employee Number:\t\t{EmployeeNumber}\n" +
                $"Job Description:\t\t{JobDescription}\n" +
                $"Department:\t\t\t{Department}\n" +
                $"Salary:\t\t\t\t${Salary:C}\n" +
                $"Sales:\t\t\t\t${Sales:C}\n" +
                $"Sale Commision:\t\t {TOTAL_SALE_COMMISSION:P0}\t${SalesCommision()}\n" +
                $"-------------------------------------------------\n" +
                $"Total Salary: \t\t\t{(SalesCommision() + Salary):C}\n" +
                $"Retirement Contribution:{RETIREMENT_CONTRIBUTION:P0} \t-${RetirementContribution():C}\n" +
                $"Social Security Tax:\t {SOCIAL_SECURITY_TAX:P0} \t-${SocialSecurityTax():C}\n" +
                $"Federal Tax:\t\t{FEDERAL_TAX:P0} \t-${Gst():C}\n" +
                $"-------------------------------------------------\n" +
                $"Net Income:\t\t\t ${((SalesCommision() + Salary) - RetirementContribution() - SocialSecurityTax() - Gst()):C}";
        }
    }
}
