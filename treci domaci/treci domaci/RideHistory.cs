using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treci_domaci
{
    public class RideHistory
    {
        private readonly List<RideMemento> _mementos = new List<RideMemento>();

        public void AddMemento(RideMemento memento)
        {
            _mementos.Add(memento);
        }

        public RideMemento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
