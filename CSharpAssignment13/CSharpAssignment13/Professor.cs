using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment13
{
    public class Professor : Person
    {
        private int BooksPublished;
        
        public Professor()
        {


        }

        public Professor(string name , int booksPublished):base(name)
        {
            this.BooksPublished = booksPublished;
        }

        public void Print()
        {
            Console.WriteLine("The Professor {0} has published total {1} books ", base.GetName, this.BooksPublished.ToString());
        }

        public override bool IsOutstanding()
        {
            if (this.BooksPublished > 4)
                return true;
            else
                return false;
        }
    }
}
