using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Admin : Users
    {
        private string role;
        
        public Admin(string role, string name, string surname, bool hasCar, Books favBook) : base(name, surname, hasCar, favBook)
        {
            this.role = role;
        }
    }
}
