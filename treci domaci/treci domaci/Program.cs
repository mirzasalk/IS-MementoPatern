using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace treci_domaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Ride ride = new Ride();
            RideHistory rideHistory = new RideHistory();

            // Postavljanje stanja i čuvanje u memento
            ride.SetState("Ride started");
            rideHistory.AddMemento(ride.SaveToMemento());
           

            // Postavljanje novog stanja i čuvanje u memento
            ride.SetState("Ride in progress");
            rideHistory.AddMemento(ride.SaveToMemento());

            // Postavljanje konačnog stanja i čuvanje u memento
            ride.SetState("Ride completed");
            rideHistory.AddMemento(ride.SaveToMemento());

            // Vraćanje stanja
            ride.RestoreFromMemento(rideHistory.GetMemento(0));
            Console.ReadLine();
        }
    }
}









