using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treci_domaci
{
    public class Ride
    {
        private string _state;

        public void SetState(string state)
        {
            Console.WriteLine($"Setting ride state to {state}");
            _state = state;
           
        }

        public RideMemento SaveToMemento()
        {
            Console.WriteLine("Saving ride state to Memento.");
            return new RideMemento(_state);
        }

        public void RestoreFromMemento(RideMemento memento)
        {
            _state = memento.GetState();
            Console.WriteLine($"Restoring ride state to {_state}");
        }
    }
}
