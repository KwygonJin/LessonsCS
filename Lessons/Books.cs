using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public struct Books
    {
        private int pages;
        private string author;
        private string name;
        private string date;

        public Books(int pages, string author, string name, string date)
        {
            this.pages = pages;
            this.author = author;
            this.name = name;
            this.date = date;
        }

        public void printBook()
        {
            Console.WriteLine($"Name: {this.name}, Author: {this.author}, Pages: {pages}");
        }
    }
}
