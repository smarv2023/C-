using System;
using System.Collections;
using System.Collections.Generic;

namespace Persons
{
    internal class Family : IEnumerable<Person>
    {
        private List<Person> members;

        public Family()
        {
            members = new List<Person>();
        }
        
        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return members.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
