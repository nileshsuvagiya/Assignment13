using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment13
{
    public class Student : Person
    {
        private double Percentage;
        public Student()
        {

        }

        public Student(string name , double percentage):base(name)
        {
            this.Percentage = percentage;
        }

        public void Print()
        {
            Console.WriteLine("Name of student is  {0} and Percentage he/she got is {1} ", base.GetName, Percentage.ToString());
        }

        public override bool IsOutstanding()
        {
            if (this.Percentage > 85)
                return true;
            else
                return false;
        }
    }
}
