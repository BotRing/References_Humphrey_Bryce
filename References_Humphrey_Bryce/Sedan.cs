using System;
using System.Collections.Generic;
using System.Text;

namespace References_Humphrey_Bryce
{
    class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License # of {LicensePlate}");
        }

        public void IncreaseSpeed() // The Increasing speed is +5 in the Sedan
        {
            Speed += 5;
        }

        public void DecreaseSpeed() // The Decreasing speed is -5 in the Sedan
        {
            Speed -= 5;
        }

    }
}
