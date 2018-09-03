using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment13
{
    public class Person
    {
        private string name;
        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public string GetName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public virtual bool IsOutstanding()
        {
            return false;
        }

    }
}
