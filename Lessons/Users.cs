using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public class Users
    {
        private string name, surname;
        private bool hasCar;
        private byte age;
        public Books favBook { get; private set; }

        public Users(string name, string surname, bool hasCar, Books favBook)
        {
            this.name = name;
            this.surname = surname;
            this.hasCar = hasCar;
            this.favBook = favBook;
        }

    }
}
