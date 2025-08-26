using System;
using System.Collections.Generic;
using System.Text;

namespace References_Humphrey_Bryce
{
    internal interface IAutomobile
    {

        public double Speed { get; }        // Allows the speed to be applied when IAutomobile's speed is requested

        public int Wheels { get; }          // Allows the wheels to be applied when IAutomobile's wheel is requested

        public string LicensePlate { get; } // Allows the license plate to be applied when IAutomobile's license plate is requested

        public void Stringify();

    }
}
