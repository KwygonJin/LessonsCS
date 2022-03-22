using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal class BraLights : ILights
    {
        public float brightless { get; set; }
        public bool isOn { get; set; }
        public Lights type { get; set; }

        public bool isLightOn()
        {
            string isOnLight = isOn ? "ON" : "OFF";
            Console.WriteLine($"Now light is {isOnLight}");
            return isOn;
        }

        public void turnOnOff(bool isOn)
        {
            this.isOn = isOn;
        }
    }
}
