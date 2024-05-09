using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Person 
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<Person> Parents { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Parents = new List<Person>();
        }

        public void DisplayInfor()
        {
            Console.Write($"Name: {Name}, Age: {Age}, Parent's Name: ");

            if ( Parents.Count != 0 )
            {
                for (int i = 0; i < Parents.Count; i++)
                {
                    Console.Write(Parents[i].Name);
                    if (i + 1 < Parents.Count)
                        Console.Write(", ");
                }
            }
            else
            {
                Console.Write("Unknown");
            }
            Console.WriteLine();
        }
    }
}




