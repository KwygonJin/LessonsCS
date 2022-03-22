using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Customer : Human
    {
        private int cash;

        public Customer(int cash, string name, string surname) : base(name, surname)
        {
            this.cash = cash;
        }


        public override void printAll()
        {
            Console.WriteLine($"Name: {this.getName()}, Surname: {this.getSurname()}, Cash: {this.cash}");
        }
    }
}
