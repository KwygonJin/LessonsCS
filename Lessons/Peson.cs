using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Peson
    {
        private byte age;
        
        public byte Age
        {
            get { return age; }
            set { 
                if (value <= 0)
                {
                    Console.WriteLine("Minimal age is 1");
                }
                else if (value > 145)
                {
                    Console.WriteLine("People can not live so much");
                }
                else
                {
                    this.age = value;
                }
            }
        }
    }
}
