using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParks
{
    internal abstract class Parks : IPark
    {
        private string name;
        private string location;
        public string Name 
        { 
            get { return this.name; }
            set { this.name = value; } 
        }

            public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        protected Parks(){ }

        protected Parks(string name)
        {
            Name = name;
        }

            protected Parks(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public abstract decimal Revenue();

        public abstract decimal CostPerVisitor();

        public override string ToString() 
        {
            return string.Format("Name: {0}", Name);
        }

    }
}
