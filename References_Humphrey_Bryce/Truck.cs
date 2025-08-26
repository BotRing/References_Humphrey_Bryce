using System;
using System.Collections.Generic;
using System.Text;

namespace References_Humphrey_Bryce
{
    class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; private set; }
        public Truck(double speedParam, double weioghtParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weioghtParam;
            LicensePlate = licenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License # of {LicensePlate}!");
        }

        public void IncreaseSpeed() // The Increasing speed is +5 in the Truck
        {
            Speed += 5;
        }

        public void DecreaseSpeed() // The Decreasing speed is -5 in the Truck
        {
            Speed -= 5;
        }
    }
}
