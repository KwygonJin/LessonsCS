using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class BankOfficer : Human
    {
        private string position;

        public BankOfficer(string position, string name, string surname) : base(name, surname)
        {
            this.position = position;
        }

        public override void printAll()
        {
            Console.WriteLine($"Name: {this.getName()}, Surname: {this.getSurname()}, Position: {this.position}");
        }
    }
}
