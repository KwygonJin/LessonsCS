using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public abstract class Human
    {
        protected string name;
        protected string surname;

        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string getName() { return name;  }
        public string getSurname() { return surname;  }
        public abstract void printAll();
    }
}
