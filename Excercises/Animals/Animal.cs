using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal abstract class Animal
    {
        // Encapsulate variables data
        private string? _name;
        private int _age;

        // Properties with additional filter
        public string? Name
        { 
            get { return _name; }
            set
            {
                if (value != null && !ValidateEntry(value))
                    _name = value;
            }
        }

        public Animal(string name, int age)
        {
            this.Name= name;
            this.Age = age;
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (ValidateEntry(value.ToString()))
                    _age = value;
            }
        }

        // Methods
        public abstract string MakeSound();

        public override string ToString()
        {
            return $"{Name} is {Age} years old, makes a {MakeSound()}, and {GetType().Name}";
        }

        // Helper method for validation
        private bool ValidateEntry(string input)
        {
            if (int.TryParse(input, out int result))
                return true;

            return false;
        }
    }
}
