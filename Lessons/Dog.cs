using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Dog : IWalk
    {
        public void sayHello()
        {
            Console.WriteLine("DOG say hello!");
        }
    }
}
