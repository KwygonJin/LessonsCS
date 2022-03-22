using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    public class House
    {
        private byte floors;
        private int year;
        private string name;

        public House()
        {
            Console.WriteLine("Empty constructor!");
        }

        public House(byte floors, int year, string name)
        {
            this.floors = floors;
            this.year = year;
            this.name = name;
        }

        public void printAll()
        {
            Console.WriteLine($"Floors: {floors} Year: {year} Name: {name}");
        }

        public void printAge()
        {
            Console.WriteLine($"Age: {2022 - year}");
        }
    }
}
