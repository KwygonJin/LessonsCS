using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Lessons
{
    [DataContract]
    internal class Animal
    {
        [DataMember] 
        public int age;
        [DataMember] 
        public string name;

        public Animal(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
