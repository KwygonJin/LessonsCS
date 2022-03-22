using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Cargo : Car
    {
        private int max_weight = 100;
        private short numWheels = 6;

        public Cargo(int max_weight, short numWheels, int weight, string model, char color, float speed) 
            : base(weight, model, color, speed)
        {
            this.max_weight = max_weight;
            this.numWheels = numWheels;
        }

        public void newWheels(short numWheels)
        {
            this.numWheels = numWheels;
            Console.WriteLine($"Weight: {this.weight} Number of wheels: {this.numWheels}");
        }

        public override void askSomething()
        {
            Console.WriteLine($"It's cargo: {this.max_weight}");
        }
    }
}
