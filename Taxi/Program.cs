using System;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek taxi
            Taxi taxi = new Taxi();

            // penentuan nilai properties
            taxi.DriverName = "Eka Bagus Erlangga";
            taxi.OnDuty = true;
            taxi.NumPassenger = 8;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DroppOffPassenger();

            Console.ReadKey();
        }
    }
}