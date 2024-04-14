using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParks
{
    internal class Park : Parks
    {
        // Variables
        private decimal price;
        private string typeOfPark;
        private string facilities;
        private int numberOfVisitor;
        private decimal annualBudget;
        private int numberOfEmployee;

        // Properties
        public decimal Price { get { return this.price; } set { price = value; } }
        public string TypeOfPark { get { return this.typeOfPark; } set { this.typeOfPark = value; } }
        public string Facilities { get { return this.facilities; } set { this.facilities = value; } }
        public int NumberOfVisitor { get { return this.numberOfVisitor; } set { this.numberOfVisitor = value; } }
        public decimal AnnualBudget { get { return this.annualBudget; } set { this.annualBudget = value; } }
        public int NumberOfEmployee { get { return this.numberOfEmployee; } set { this.numberOfEmployee = value; } }

        // Constructors
        public Park() { }
        public Park(string name) : base(name) { }
        public Park(string name, string location) : base(name, location) { }
        public Park(string name, string location, string typeOfPark) : base(name, location)
        {
            TypeOfPark = typeOfPark;
        }
        public Park(string name, string location, string typeOfPark, string facilities) : base(name, location) 
        {
            TypeOfPark = typeOfPark;
            Facilities = facilities;
        }
        public Park(string name, string location, string typeOfPark, string facilities, decimal price) : base(name, location)
        {
            TypeOfPark = typeOfPark;
            Facilities = facilities;
            Price = price;
        }
        public Park(string name, string location, string typeOfPark, string facilities, decimal price, int numberOfEmployee) : base(name, location)
        {
            TypeOfPark = typeOfPark;
            Facilities = facilities;
            Price = price;
            NumberOfEmployee = numberOfEmployee;
        }
        public Park(string name, string location, string typeOfPark, string facilities, decimal price, int numberOfEmployee, int numberOfVisitor) : base(name, location)
        {
            TypeOfPark = typeOfPark;
            Facilities = facilities;
            Price = price;
            NumberOfEmployee = numberOfEmployee;
            NumberOfVisitor = numberOfVisitor;
        }
        public Park(string name, string location, string typeOfPark, string facilities, decimal price, int numberOfEmployee, int numberOfVisitor, decimal annualBudget) : base(name, location)
        {
            TypeOfPark = typeOfPark;
            Facilities = facilities;
            Price = price;
            NumberOfEmployee = numberOfEmployee;
            NumberOfVisitor = numberOfVisitor;
            AnnualBudget = annualBudget;
        }
        public override decimal Revenue()
        {
            return NumberOfVisitor * Price;
        }
        public override decimal CostPerVisitor()
        {
            return AnnualBudget / NumberOfVisitor;
        }

        // To string method
        public override string ToString()
        {
            /*return string.Format("Park Name: {0}\nLocation: {1}\nType of park: {2}\nFacilities: {3}\nPrice: {4:C}\nNumber of Employee: {5}\nAnnual number of visitor: {6:#,##0}\nAnnual Budget: {7:C}",
                Name, Location, TypeOfPark, Facilities, Price, NumberOfEmployee, NumberOfVisitor, AnnualBudget);*/

            string printOut = "";
            if (Name != null)
            {
                printOut += string.Format("Park Name: {0}\n", Name);
            }

            if (Location != null)
            {
                printOut += string.Format("Location: {0}\n", Location);
            }

            if (TypeOfPark != null)
            {
                printOut += string.Format("Type of park: {0}\n", TypeOfPark);
            }

            if (Facilities != null)
            {
                printOut += string.Format("Facilities: {0}\n", Facilities);
            }

            if (Price != 0)
            {
                printOut += string.Format("Price: {0}\n", Price.ToString("C"));
            }

            if (NumberOfEmployee != 0)
            {
                printOut += string.Format("Number of Employee: {0}\n", NumberOfEmployee);
            }

            if (NumberOfVisitor != 0)
            {
                printOut += string.Format("Number of visitor: {0:#,##0}\n", NumberOfVisitor);
            }

            if (AnnualBudget != 0)
            {
                printOut += string.Format("Annual budget: {0}\n", AnnualBudget.ToString("C"));
            }

            return printOut;
        }
    }
}
