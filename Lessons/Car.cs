using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class Car
    {
		public int weight;
		public string model;
		public char color;
		public float speed;

		public Car(int weight, string model, char color, float speed)
        {
			this.weight = weight;
			this.model = model;
			this.color = color;
			this.speed = speed;
        }

		public void outPut()
		{
			Console.WriteLine("Weight of " + model + " is " + weight + "kg.");
			Console.WriteLine("Color is " + color + " and it speed - " + speed);
		}

		public virtual void askSomething()
        {
            Console.WriteLine($"It's car class and speed: {this.speed}");
        }

	}
}
