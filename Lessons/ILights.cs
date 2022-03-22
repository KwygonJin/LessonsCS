using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons
{
    internal interface ILights
    {
        float brightless { get; set; }
        bool isOn { get; set; }
        Lights type { get; set; }

        void turnOnOff(bool isOn);
        bool isLightOn();
    }
}
