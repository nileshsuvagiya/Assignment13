using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Professor("Adam Freeman", 50),
                new Professor("Gred Lim", 4),
                new Professor("Krishna Rungta", 10),
                new Student("Christopher Coleman", 90.9),
                new Student("Mark Myers", 84.88)
            };

            foreach (var item in persons)
            {
                if(item is Professor && item.IsOutstanding())
                {
                    ((Professor)item).Print();
                }

                if (item is Student && item.IsOutstanding())
                {
                    ((Student)item).Print();
                } 
            }

            Console.ReadLine();
        }
    }
}
