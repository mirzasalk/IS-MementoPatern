using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treci_domaci
{
    public class RideMemento
    {
        private readonly string _rideState;

        public RideMemento(string state)
        {
            _rideState = state;
        }

        public string GetState()
        {
            return _rideState;
        }
    }
}
