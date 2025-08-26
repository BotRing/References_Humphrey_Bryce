using References_Humphrey_Bryce;
using System;

namespace Refrences_Humphrey_Bryce
{
    class Program
    {

        static void Main(string[] args)
        {
                // Saves Sedan as myFirstSedan alsos says myAutomobile is myFirstSedan
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

                // Saves myOtherSedan in another place
            Sedan myOtherSedan = new Sedan(0);
            
                // Shows the speed of myFirstSedan and myAutomobile + checks if they are the same thing
            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

                // Shows the speed of myFirstSedan and myOtherSedan + checks if they are the same thing
            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myOtherSedan.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            Truck myTruck = new Truck(50, 500, "MyTruck");

                // Calls stringify Method and describes Automobiles
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();

        }
    }
}